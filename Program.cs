void Zadacha63()
{
  // Задайте значение N.напишите программу ,которая выведет все натуральные числа в промежутке от 1 до N


  int number = 15 ;
  int count = 1 ;
  Recursion(count , number);
  Console.WriteLine();


  void Recursion(int count, int number)
  {
    if (count > number) return ;
    Console.Write(count + "  ");
    count++;
    Recursion(count , number);
  }
   
  

}
Zadacha63();


void Zadacha58() 
{ 
  int rows = 4;
  int columns = 4;

  int  Index_i = 0;
  int  Index_j = 0;

  int change_i = 0;
  int change_j = 1;

  int steps = columns;
  int turnCount = 0;
 
  int[,] array = new int[rows, columns];

  

  for (int i = 1; i <= array.Length; i++)
  {
    array[Index_i, Index_j] = i;
    Console.Write(array[Index_i, Index_j] + "\t");
    
    steps--;
    if(steps == 0)
    {
        steps = rows -1 - turnCount/2;

        int temp = change_i;
        change_i = change_j;
        change_j = -temp; 
        turnCount++;
    }

    Index_i+= change_i ;
    Index_j+= change_j ;
  }
  
  
  Console.WriteLine();
  PrintArray(array);  




  void PrintArray(int[,] array)
            
                Console.WriteLine("Вывод массива");
                
                int rows = array.GetLength(0);
                int сolumns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
    
}
//Zadacha58();


