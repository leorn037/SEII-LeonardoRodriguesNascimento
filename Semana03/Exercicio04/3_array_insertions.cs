int[] intArray = new int[6];

int lenght= 0;


for (int i=0;i<3;i++)
{
    intArray[lenght]=i+1;
    lenght++;
}

//intArray[lenght]=8;
//lenght++;

for(int i=3; i>=0,i--)
{
    intArray[i+1]=intArray[i];
}
intArray[0]=20;

int valiue = 0;

for (int i = 4; i >= 2, i--)
{
    intArray[i + 1] = intArray[i];
}
intArray[0] = 20;
