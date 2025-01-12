using oop2;
using System;
using System.Collections.Generic;

OrganizationUnit company = new OrganizationBuilder()   
.AddDepartment("návrh", 5, 0)           //jak se jmenuje, kolik má lidí, a kolik se odečítá od jejich platu (určje to jakoby platové kategorie
.AddDepartment("výroba", 3, 0)          
.AddDepartment("prodej", 2, 1000)        
.AddSubDepartment("návrh", "team grafiků", 4, 20000)
.AddSubDepartment("výroba", "střih", 3, 20000)
.AddSubDepartment("střih", "kontrolu kvality", 3, 25000)
.AddSubDepartment("výroba", "šití", 2, 20000)
.AddSubDepartment("prodej", "designeři obsalů", 1, 20000)
.Build();

company.DisplayHierarchy();
Console.WriteLine($"počet zaměstnanců: {company.GetTotalEmployees()}");
Console.WriteLine($"počet zaměstnanců: {company.GetTotalmoney()} kč");

