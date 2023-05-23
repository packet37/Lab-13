using ConsoleApp1;

DoublyLinkedList linkedList = new DoublyLinkedList();

linkedList.Add(int.Parse(Console.ReadLine()));
linkedList.Add(int.Parse(Console.ReadLine()));
string str;
while ((str=Console.ReadLine()) != "")
{
    //if (Math.Abs(str - linkedList.GetHead))
    linkedList.Add(int.Parse(str));
}

Console.WriteLine(linkedList.ToString());

//// добавление элементов
//linkedList.Add(1);
//linkedList.Add(2);
//linkedList.Add(3);
//linkedList.AddFirst(0);
//foreach (var item in linkedList)
//{
//    Console.WriteLine(item);
//}
//// удаление
//linkedList.Remove(2);

//// перебор с последнего элемента
//foreach (var t in linkedList.BackEnumerator())
//{
//    Console.WriteLine(t);
//}
//Console.WriteLine(linkedList.Count);    