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
XYZCompany.Employees1.Add(managerJohn);
XYZCompany.Employees1.Add(managerMary);
XYZCompany.Employees1.Add(accountantJane);
XYZCompany.Employees1.Add(accountantJoe);
XYZCompany.Employees1.Add(blacksmithJack);
XYZCompany.Employees1.Add(blacksmithKatie);
XYZCompany.Employees1.Add(blacksmithAmy);
XYZCompany.Employees1.Add(blacksmithLin);
XYZCompany.Employees1.Add(blacksmithGreg);
XYZCompany.Owner1 = ownerCraig;

// Owner sends good job to John, Jane, and Jack
ownerCraig.send("Good Job", [managerJohn, accountantJane, blacksmithJack]);
// Amy delegates Greg for help on her task2
blacksmithAmy.Employee = blacksmithGreg;
// Greg performs his own task and helps amy with task2
blacksmithGreg.perform(blacksmithAmy);
// Accountant Jane increases Greg's salary by $1000
accountantJane.update(blacksmithGreg.Salary + 1000, blacksmithGreg);
// Lin delegates Jane for help on her task3
blacksmithLin.Employee = accountantJane;
// Lin performs task 3 and Jane helps
blacksmithLin.perform();
// John delegates Craig to perform his evaluations
managerJohn.Evaluator = ownerCraig;
// Craig evaluates Jack on John's behalf
managerJohn.evaluate(blacksmithJack, 4);
// Mary evaluates Katie
managerMary.evaluate(blacksmithKatie, 5);