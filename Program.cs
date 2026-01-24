using Lab2;
using Task = Lab2.Task;

Owner ownerCraig = new Owner("Craig");
Task t1 = new Task("t1");
Task t2 = new Task("t2");
Task t3 = new Task("t3");
Manager managerJohn = new Manager("John");
Manager managerMary = new Manager("Mary");
Accountant accountantJane = new Accountant("Jane");
Accountant accountantJoe = new Accountant("Joe");
Blacksmith blacksmithJack = new Blacksmith("Jack");
Blacksmith blacksmithKatie = new Blacksmith("Katie");
Blacksmith blacksmithAmy = new Blacksmith("Amy", t2);
Blacksmith blacksmithLin = new Blacksmith("Lin", t3);
Blacksmith blacksmithGreg = new Blacksmith("Greg", t1);
Company XYZCompany = new Company();
XYZCompany.Employees.Add(managerJohn);
XYZCompany.Employees.Add(managerMary);
XYZCompany.Employees.Add(accountantJane);
XYZCompany.Employees.Add(accountantJoe);
XYZCompany.Employees.Add(blacksmithJack);
XYZCompany.Employees.Add(blacksmithKatie);
XYZCompany.Employees.Add(blacksmithAmy);
XYZCompany.Employees.Add(blacksmithLin);
XYZCompany.Employees.Add(blacksmithGreg);
XYZCompany.Owner = ownerCraig;


ownerCraig.send("Good Job", [managerJohn, accountantJane, blacksmithJack]);
blacksmithGreg.perform(blacksmithAmy);
accountantJane.update(blacksmithGreg.getSalary() + 1000, blacksmithGreg);
blacksmithLin.requestHelp(accountantJane);
managerJohn.requestHelp(ownerCraig);
ownerCraig.evaluate(blacksmithJack, 4);
managerMary.evaluate(blacksmithKatie, 5);