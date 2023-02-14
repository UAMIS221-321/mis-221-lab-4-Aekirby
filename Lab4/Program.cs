int choice = 0;
while(true)
{
    Console.WriteLine("Press 1 to display full triangle, Press 2 to display partial triangle, Press 3 to exit");
    choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1)
    {
        Random rnd = new Random();
        int number = rnd.Next(3, 9);
        for(int i = 1; i <= number; i++)
        {
            for(int a = 1; a <= i; a++)
            {
                Console.Write("o");
            }
            Console.WriteLine("");
        }
    }

    else if(choice == 2)
    {
       Random rnd = new Random();
        int number = rnd.Next(3, 9);
        for(int i = 1; i <= number; i++)
        {
            for(int a = 1; a <= i; a++)
            {
                Random rand = new Random();
                int Option = rand.Next(2);
                if(Option == 0)
                {
                    Console.Write("o");
                }
                else if(Option == 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }

    else if(choice == 3)
    {
        return 0;
    }

    else
    {
        Console.WriteLine("Invalid choice");
    }
}