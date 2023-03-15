using PatterninCSharp.Opps;
using PatterninCSharp.Program;

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