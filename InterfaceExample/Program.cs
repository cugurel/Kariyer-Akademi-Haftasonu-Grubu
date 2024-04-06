using InterfaceExample;

Car car = new Car();
car.Id = 1;
car.Brand = "Mercedes";
car.Model = "AMG";
car.Year = 2023;
car.Price = "3.000.000";

CarManager cm = new CarManager();
cm.DisplayCarProp(car);