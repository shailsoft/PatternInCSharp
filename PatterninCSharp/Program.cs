
using PatterninCSharp;
using PatterninCSharp.Program;

RunGenericProgram runGenericProgram =new RunGenericProgram();
runGenericProgram.AllForLoopProgram();
Console.ReadLine();

var res = GetCurrentIPOrMacAddress.GetLocalIPAddress();
var MACAddress = GetCurrentIPOrMacAddress.GetMACAddress();

AllPattern.RightUpperAngleTriangle();
AllPattern.RightLowerAngleTriangle();
AllPattern.LeftUpperAngleTriangle();
AllPattern.LeftLowerAngleTriangle();
AllPattern.SquarePrint();


#region Predefine

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.ReadLine();

#endregion