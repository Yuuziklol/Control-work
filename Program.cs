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
string [] OutputArray = new string[CountElements(InputArray)];
int index = 0;
int length = InputArray.Length;
for (int i = 0; i < length; i=i+1)
{
    if (InputArray[i].Length <= 3)
    {
        OutputArray[index] = InputArray[i];
        index = index + 1;
    }
}
string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i = i + 1)
    {
        output = output + ($"array[{i+1}]: {array[i]} \n");
    }
    return output;
}
string input = Print(InputArray);
File.WriteAllText("input.txt", input);

string output = Print(OutputArray);
File.WriteAllText("output.txt", output);