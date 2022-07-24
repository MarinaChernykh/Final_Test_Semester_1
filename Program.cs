
string[] CreateNewArray(string[] inputArray)
{
    int counter = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3) counter++;
    }
    string[] outputArray = new string[counter];
    return outputArray;
}

string[] FillAray(string[] inputArray, string[] outputArray)
{
    return outputArray;
}

void PrintArray(string[] array)
{

}


string[] array = {"hello", "2", "world", ":-)"};
string[] createdArray = CreateNewArray(array);
FillAray(array, createdArray);
PrintArray(array);
PrintArray(createdArray);