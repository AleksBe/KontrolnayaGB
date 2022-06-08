string[]array = {"Москва", "Владивосток", "Уфа", "Коля", "Оля", "уж", ":-)"};

void CorrectArray(string[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length > 3) array[i] = string.Empty;
    }
}


