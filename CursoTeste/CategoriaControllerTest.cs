using CursoApi.Controllers;
using CursoMVCC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace CursoTeste
{
   public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Contexto> _mockContexto;
        private readonly Categoria _categoria;

        public CategoriaControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContexto = new Mock<Contexto>();
            _categoria= new Categoria { Id=1,Descricao="Teste Descrição"};
            _mockContexto.Setup(m => m.Categorias).Returns(_mockSet.Object);

            _mockContexto.Setup(m => m.Categorias.FindAsync(1))
                .ReturnsAsync(_categoria);
        }


        [Fact]
        public async System.Threading.Tasks.Task Get_categorias()
        {
            var service = new CategoriasController(_mockContexto.Object);

            await service.Categoriasid(1);

            _mockSet.Verify(m => m.FindAsync(1), 
                Times.Once());
        }
    }
}
