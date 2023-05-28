using proyecto;

Vehiculobase vehiculo=new Vehiculobase("toyota","rvu","negro",2020,"C03234","Camioneta",250);

vehiculo.Encender();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
vehiculo.Bocina();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
vehiculo.Acelerar(30);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
vehiculo.Frenar(15);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
vehiculo.Apagar();
vehiculo.Encender();
Console.WriteLine("Presiona tecla....");
Console.ReadKey(); 
Console.Clear();

Pickup pick = new Pickup("toyota", "f-23", "Rojo", 2020, "C32332", "Pickup", 215, 1000, true, "4x4");

pick.Encender();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey();Console.WriteLine();
pick.Bocina();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
pick.Acelerar(45);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
pick.Frenar(32);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
pick.Apagar();
pick.Encender();
pick.cargar(342);
Console.WriteLine("Presiona tecla ....");
Console.ReadKey();
Console.Clear();
sedan Sedan = new sedan("toyota", "camry", "azul", 2018, "A12324", "sedan", 250, true, "automatica", "Deportivo");

Sedan.Encender();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
Sedan.Bocina();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
Sedan.Acelerar(70);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
Sedan.Frenar(50);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
Sedan.Apagar();
Sedan.Encender();
Sedan.encenderaire();
Console.WriteLine("Presiona tecla ....");
Console.ReadKey();
Console.Clear();

suv suv1 = new suv("Jeep", "Wrangler", "negro", 2022, "B0321B", "SUV", 180, 5, true, "Suspension todo terreno");
suv1.Encender();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
suv1.Bocina();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
suv1.Acelerar(50);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
suv1.Frenar(45);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
suv1.Apagar();
suv1.Encender();
suv1.activarmodoOfroad();
Console.WriteLine("Presiona tecla ....");
Console.ReadKey();
Console.Clear();

M4x4 m14x4 = new M4x4("Ford","Ranger","Rojo",2022,"C0234BB","4x4",200,30,true,"Traccion integral");
m14x4.Encender();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
m14x4.Bocina();
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
m14x4.Acelerar(80);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
m14x4.Frenar(35);
Console.WriteLine("Presiona tecla para ejecutar la funcion");
Console.ReadKey(); Console.WriteLine();
m14x4.Apagar();
m14x4.Encender();
m14x4.encenderequipo(); 



