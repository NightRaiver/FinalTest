int[] array = new int[] { -2, -1, 0, 1, 2 };
void ArrayOfEvenNumbers (int[] array) {
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0) Console.Write($"{array[index]} ");
    }
}
ArrayOfEvenNumbers(array);