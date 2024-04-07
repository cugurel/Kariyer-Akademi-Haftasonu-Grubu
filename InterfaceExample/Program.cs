using InterfaceExample.Concrete;

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

Log log = new Log();
log.Id = 1;
log.Username = "cagri";
log.Process = "Login Başarılı";
log.Status = 1;
log.Date = DateTime.Now;

LogManager lm = new LogManager();
lm.TAdd(log);

//CarManager cm = new CarManager();
//cm.TAdd(car);

//CustomerManager customerManager = new CustomerManager();
//customerManager.TAdd(customer);