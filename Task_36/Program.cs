/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//1. получить размерность массива с консоли 
int GetNumber(string message) 
{    
    int result;      
    while(true)     
    {        
        Console.WriteLine(message);                  
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)        
        {            
            break;      
        }       
        else      
        {            
            Console.WriteLine("Ввели не число. Введите корректное число");      
        }    
    }    
    return result;
} 
//2. получить заполненный массив рандомными числами 
int[] InitArray(int dimension) 
{     
    int[] array = new int[dimension];     
    Random rnd = new Random();      
    for (int i = 0; i < dimension; i++)    
    {       
          array[i] = rnd.Next(-20, 20);     
    }     
    return array;
}
//3. распечатать массив на консоль  
void PrintArray(int[] array)
{     
    for (int i = 0; i < array.Length; i++)    
    {        
        Console.Write($"{array[i]} ");    
    }      
    Console.WriteLine(); 
} 
int GetSummOddnymbers(int[] array)
 {     int summ = 0;     
    for (int i = 1; i < array.Length; i+=2)    
    {                     
        summ += array[i];    
    }     
    return summ; 
} 
int dimension = GetNumber("Введите размерность массива:"); 
int[] array = InitArray(dimension); 
PrintArray(array); 
 
 Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetSummOddnymbers(array)}"); 