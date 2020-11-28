# DigitalInovation

# Dependencias instaladas
- Swashbuckle.AspNetCore 

# Configurações
- Adicionar na Startup do projeto API
- services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Curso Api", Version = "v1" }); });
- app.UseSwagger();
- app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Curso Api"); });
