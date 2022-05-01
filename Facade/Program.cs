// See https://aka.ms/new-console-template for more information

using Facade;

var initialization = new Initialization();
var calculation = new Calculation();

new ApplicationFacade(calculation, initialization).Operate();

