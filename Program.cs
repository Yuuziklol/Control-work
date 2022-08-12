string [] InputArray = {"Moscow2", "ks3", "cow", "k:52", "Silense", "car", "home", "cs", "a", "425light"};

int CountElements(string [] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i = i+1)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return(count);
}



