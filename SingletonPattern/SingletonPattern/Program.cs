// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Singleton singleton = Singleton.Instance;
singleton.SomeData = "Hello, Singleton!";
singleton.SomeMethod();

