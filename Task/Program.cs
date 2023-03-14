Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	arr1[i] = result;  
}
Console.WriteLine(string.Join(",", arr1));

int count = 0;
int maxNum = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= maxNum){
		count++;
	}   
}
Console.WriteLine("Полученный массив: ");

string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxNum){
        arr2[j] = arr1[i];
       Console.Write(arr2[j] + ",");
        j++;
    }
}
