﻿List<object> myList = new List<object>();
myList.Add(7);
myList.Add(28);
myList.Add(-1);
myList.Add(true);
myList.Add("chair");

int sum = 0;
foreach(var item in myList){
    Console.WriteLine(item);
    if(item is int){
        sum += (int) item;
    }
}
Console.WriteLine(sum);