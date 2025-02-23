int[] intArray = {-22, -15, 2, 7, 20, 30, 54};

Console.WriteLine(BinarySearch(intArray, 2);

int BinarySearch(int[] intArray, int value)
{
    int start = 0;
    int end = 0;

    while (start <end)
    {
        int midpoint=(start+end)/2;

        if(intArray[midpoint]==value)
        {
            return midpoint
        }
        else if(intArray[midpoint]<value){
            start = midpoint +1;}
        else
        {
            end = midpoint;
        }
    }
    return -1
}

