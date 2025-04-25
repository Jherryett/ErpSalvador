// Bibliotecas do .NET padrão

global using System;
global using Microsoft.AspNetCore.Mvc; // Desenvolvimento Web APIs
global using Microsoft.Extensions.DependencyInjection; // Fazer as injeções de dependências do sistema




// Bibliotecas do NuGet + link de importação (Importar uma vez para cada projeto)



// Bibliotecas para a Idle + link de importação (Importar somente uma vez para a Idle inteira)

global using Microsoft.EntityFrameworkCore; // dotnet tool install --global dotnet-ef 
global using Microsoft.EntityFrameworkCore.Design; // dotnet add package Microsoft.EntityFrameworkCore.Design
global using Microsoft.EntityFrameworkCore.SqlServer; // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// o pacote Tools é importante ter, mas é usado em tempo de design e não é aplicado com Using;   dotnet add package Microsoft.EntityFrameworkCore.Tools









// global using Microsoft.EntityFrameworkCore.Design; // dotnet add package Microsoft.EntityFrameworkCore.Design




// Arquivos de código (Classes, Entidades)

global using ErpSalvador.Entities;
global using ErpSalvador.Services;
global using ErpSalvador.Context;
global using ErpSalvador.Repositories;
global using ErpSalvador.Interfaces;



