using InterfaceExample;

Car car = new Car();
car.Id = 1;
car.Brand = "Mercedes";
car.Model = "AMG";
car.Year = 2023;
car.Price = "3.000.000";


Customer customer = new Customer();
customer.Id = 1;
customer.Name = "Çağrı";
customer.Surname = "Uğurel";
customer.City = "İzmir";
customer.Town = "Bayraklı";


CarManager cm = new CarManager();
cm.TAdd(car);

CustomerManager customerManager = new CustomerManager();
customerManager.TAdd(customer);