using TaskIOutput;

var testArray = new MyArray(67, 32, 83, 764);
var testArray2 = new MyArray(2, 9, 0);

#region IOutput
testArray.Show("Let's see if this works :)\n");

testArray2.Show();
#endregion


#region IMath
int maxOfArray = testArray.Max();
Console.WriteLine($"The highest number of the first array is {maxOfArray}");

int minOfArray = testArray.Min();
Console.WriteLine($"The lowest number of the first array is {minOfArray}");

int searchedNumber = 8;
if(testArray.Search(searchedNumber))
{
    Console.WriteLine($"Yes, there's {searchedNumber} in the array");
}
else
{
    Console.WriteLine($"No, there's no {searchedNumber} in the array");
}

Console.WriteLine($"The average number of the array is {testArray.Avg()}");
#endregion

#region ISort

Console.WriteLine("Sorted ascending:");
testArray.SortAsc();
testArray.Show();

Console.WriteLine("Sorted descending:");
testArray.SortDesc();
testArray.Show();

Random rand = new Random();
bool isAsc = rand.Next(0, 2) == 1;

Console.WriteLine($"\nSorting by param randomly: {(isAsc ? "Ascending" : "Descending")}");
testArray2.SortByParam(isAsc);
testArray2.Show();
#endregion