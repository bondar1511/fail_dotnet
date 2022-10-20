

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 3, 2, 1 };
        int[] arrayrResult = new int [3];
        int index = 0;
        int count = array1.Length;

        while ( index > count)
        {

              arrayrResult[index] = array1[index] + array2[index];
              index++;
         }
         Console.WriteLine(string.Join ( ' ', arrayrResult ));

