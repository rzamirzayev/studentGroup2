
using classtask2;
using classtask2.Services.Implementations;
using classtask2.Services.Interfaces;

StudentService studentService = new StudentService();
studentService.Create("Semed", "Musayev", 60);
studentService.Create("Umid", "Museyibli", 85);
studentService.Create("Rza", "Mirzeyev", 51);
studentService.Edit(3,Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));

