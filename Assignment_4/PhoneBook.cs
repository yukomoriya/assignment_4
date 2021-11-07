using System;
using System.Linq;

class PhoneBook 
{
    private string[] names = { "Olof", "Elin", "Cathy", "Emma", "Jayeon" };
    private string[] phones = { "040-1231", "040-1232", "040-1233", "040-1234", "040-1235" };

    public PhoneBook()
    {
        Console.Clear();

        DisplayList();
        Console.WriteLine();

        DisplayList(); 
        int count = names.Length;
        
        SortByName(); 
    }


public void DisplayList()
{ 
    // private string [,] phoneList; = new phoneList [,]

    System.Console.WriteLine("Names length:" + names.Length);

    for (int i = 0; i < names.Length; i++)
    {

        Console.WriteLine("{0,-15} {1,-15}",names[i], phones[i]);
    } 
    // Console.WriteLine(nemes[0]+ phones[0]);            
    // Console.WriteLine(nemes[1]+ phones[1]);            
    // Console.WriteLine(nemes[2]+ phones[2]);
    // Console.WriteLine(nemes[3]+ phones[3]);
    // Console.WriteLine(nemes[4]+ phones[4]);

}

    public void AddPhoneNumber()
    {

        string number = Console.ReadLine();
        string name = Console.ReadLine();
        names = names.Concat(new string[] { name }).ToArray();
        phones = phones.Concat(new string[] { number }).ToArray();
        DisplayList();
    }

    public void SortByName() 
    {   
        
        int length = names.Length; 

        for (int i = 0; i< length -1; i ++) 
        {
            for (int j = 0; j < length - i -1; j++)
            {
                if (names[j].CompareTo( names [ j + 1]) > 0)
                {
                    Swap(j);
                }
            }
        }
    }

    private void Swap(int j)
    {
        string temp = names[j];
        names[j] = names[j + 1];
        names[j + 1] = temp;

        temp = phones[j];
        phones[j] = phones[j + 1];
        phones[j + 1] = temp;
    }

    private string[,] phoneList;

    public void FillTable() 
    {
        phoneList = new string[names.Length,2];
        for (int i = 0; i < names.Length; i++) 
        {
            phoneList[i,0] = names[i];
            phoneList[i,1] = phones[i];
        }
    } 

    public void DisplayTable()
    {
       System.Console.WriteLine("PhoneList length:" + phoneList.Length);

    for (int i = 0; i < phoneList.GetLength(0); i++)
    {

        Console.WriteLine("{0,-15} {1,-15}",phoneList[i,0], phoneList[i,1]);
    }  
    }
}