int[] array= new int[]{1, 2, 3, 4, 5, 6, 7, 8,, 9, 10};
bool LinearSearch(int[] array, int key)
{
    for(int i=0;i<array.Lenght;i++)
    {
        if(array[i]==key)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine(LinearSearch(array,4));