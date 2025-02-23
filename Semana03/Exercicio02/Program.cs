string[] MyArray = new string[7];

MyArray[0]="Monday";
MyArray[1]="Tuesday";
MyArray[2]="Wednesday";
MyArray[3]="Thursday";
MyArray[4]="Friday";
MyArray[5]="Saturday";
MyArray[6]="Sunday";

for (int i=0;i<MyArray.Length;i++){
Console.WriteLine(MyArray[i]);
}



List<string> list= new List<string>();

list.Add("Monday");
list.Add("Tuesday");
list.Add("Wednesday");
list.Add("Thursday");
list.Add("Friday");
list.Add("Saturday");
list.Add("Sunday");

for (int i=0;i<list.Count;i++)
{
    list[i]=list[i].Substring(0,3);
    Console.WriteLine(list[i]);
}



Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary[0]="Monday";
dictionary[1]="Tuesday";
dictionary[2]="Wednesday";
dictionary[3]="Thursday";
dictionary[4]="Friday";
dictionary[5]="Saturday";
//dictionary[6]="Sunday";
dictionary.Add(6,"Sunday");

for (int i=0;i<dictionary.Count;i++)
{
    dictionary[i]=dictionary[i].Substring(0,3);
    Console.WriteLine(dictionary[i]);
}