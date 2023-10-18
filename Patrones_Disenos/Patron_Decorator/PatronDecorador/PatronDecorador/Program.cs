﻿// See https://aka.ms/new-console-template for more information



using PatronDecoratorC;

BebidaComponent cafe = new CafeDescafeinado();
cafe = new Crema(cafe);
cafe = new Edulcorante(cafe);
cafe = new Canela(cafe);

Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

cafe = new CafeExpresso();
cafe = new Leche(cafe);
cafe = new Edulcorante(cafe);
cafe = new Canela(cafe);

Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

cafe = new CafeSolo();
cafe = new Edulcorante(cafe);

Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");


Console.ReadKey();

