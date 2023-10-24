using PatterninCSharp.LogicalProgram;
using PatterninCSharp.Opps;
using PatterninCSharp.Program;
using static PatterninCSharp.Opps.EncapsulationAndAbstraction;


//ICar obj = new ICar();
//obj.get();

LogicalProgram.CheckExist();
int number = FindVowelsAndConsFromArray.FindVowelsWithHelpArray("Shailendra Kumar Bharyi");
Console.ReadLine();

LogicalProgram.CheckFirstNdSecNumberEqualToThird(1, 2, 3);
LogicalProgram.ExistInArray(new[] { 1, 2, 9, 3 }, 3);

LogicalProgram.CheckGivenNumber(3);
Console.ReadLine();
LogicalProgram.ReplaceFirstToLast("Shailendra");
LogicalProgram.ReturnTripple(2, 3);
LogicalProgram.ReturnTripple(2, 3);

Console.ReadLine();


FindAndWhere.FindAndWhereDiff();
Console.ReadLine();



#region Encapsulation & Abstraction
BankAccount myAccount = new BankAccount(1000);
myAccount.Deposit(500);
Console.WriteLine("Balance: " + myAccount.GetBalance());

myAccount.Withdraw(1200);
Console.WriteLine("Balance: " + myAccount.GetBalance());
#endregion
Console.ReadLine();
#region Singleton

SingletonPattern si = SingletonPattern.GetInstance();
SingletonPattern s2 = SingletonPattern.GetInstance();
//SingletonPattern.OtherClass o = new SingletonPattern.OtherClass();

if (si == s2)
{
    Console.WriteLine(si == s2);

}
Console.WriteLine(s2);

#endregion



Console.ReadLine();

var sss = ExtensionMethod.Add(10, 5);
var ssss = ExtensionMethod.Add(10, 5).AddExtension();
Console.ReadLine();

JaggedArrayTest.JaggedArry();

//Constructor defConst = new Constructor();
//Constructor perConst = new Constructor(20);

Console.ReadLine();
BabulSort.ShortingString();
BabulSort.SortData();
Console.ReadLine();
MethodOverRiding baseClass = new MethodOverRiding();
MethodOverRidingDerivedClass DerivedClass = new MethodOverRidingDerivedClass();
MethodOverRiding BaseClassWithDerive = new MethodOverRidingDerivedClass();


baseClass.Method1();
baseClass.Method2();

// derive
DerivedClass.Method1();
DerivedClass.Method2();

// derive
BaseClassWithDerive.Method1();
BaseClassWithDerive.Method2();




MethodOverload overLoadingOverRiding = new MethodOverload();
overLoadingOverRiding.Add(100, 1);
overLoadingOverRiding.Add(100, "Shailendra");
Square.SquarePrint();




StringAndStringBuilder.StringBuilders();


AllPattern.NaturalNumbers();



#region FactorialNumber
FactorialNumber.FactorialGivenNumber();
#endregion

#region FibonacciSeries
FibonacciSeries.Fibonacciseries();
#endregion

#region PrimeNumOrNot
PrimeNumberOrNot.PrimeNumOrNot();
#endregion

#region String And StringBuilder
StringAndStringBuilder.SpltStringAfterNComma();
StringAndStringBuilder.SpltStringAfterNCommaByChunk();
StringAndStringBuilder.String();
StringAndStringBuilder.StringBuilders();
#endregion

#region NullCoalescing Operator
NullCoalescingOperator.NullCoalseing();
#endregion

#region Palindrome string
PalindromeString.PalindromeStringOrNot();
#endregion

#region Swapping numbers
SwappingTwoNumbers.SwappingTwoNoWithoutThirdVariable();
SwappingTwoNumbers.SwappingTwoNoWithoutThirdVariable1();
#endregion

#region Reverse Charchtors
ReversCharchors.ReversChar();
ReversCharchors.ReversWordWithoutChngPosition();
ReversCharchors.ReversCharWithoutChngPosition();
ReversCharchors.ReverseNumberSecWay();
#endregion

#region Dictionary and Hash
DictionaryList dicObj = new DictionaryList();
dicObj.Dictonary();
dicObj.Hashtable();
#endregion

#region Breack Continue and Goto
BreakContinueGoto.Break();
BreakContinueGoto.Continue();
BreakContinueGoto.Goto();
#endregion

#region All Patterns
AllPattern.RightUpperAngleTriangle();
AllPattern.RightLowerAngleTriangle();
AllPattern.LeftUpperAngleTriangle();
AllPattern.LeftLowerAngleTriangle();
AllPattern.SquarePrint();
AllPattern.PyramidWithNumber();
AllPattern.PyramidUsingAsterisk();
AllPattern.Diamond();
#endregion

//Console.ReadLine();
#region Predefine

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.ReadLine();

#endregion



//using PatterninCSharp;
//using PatterninCSharp.Program;

//RunGenericProgram runGenericProgram =new RunGenericProgram();
//runGenericProgram.AllForLoopProgram();
//Console.ReadLine();

//var res = GetCurrentIPOrMacAddress.GetLocalIPAddress();
//var MACAddress = GetCurrentIPOrMacAddress.GetMACAddress();

//AllPattern.RightUpperAngleTriangle();
//AllPattern.RightLowerAngleTriangle();
//AllPattern.LeftUpperAngleTriangle();
//AllPattern.LeftLowerAngleTriangle();
//AllPattern.SquarePrint();


//#region Predefine

//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//Console.ReadLine();

//#endregion

