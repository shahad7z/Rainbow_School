
using System;
using System.IO;


class Opration
{

public void writeData()
    {
        try
        {
            using (FileStream fs = new FileStream("//Users//shahadsh//Documents//project//teacherFile.txt", FileMode.CreateNew, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.Write("Enter the ID :");
                    string ID = Console.ReadLine();
                    sw.WriteLine("ID :" + ID);
                    Console.Write("Enter the Name :");
                    string Name = Console.ReadLine();
                    sw.WriteLine("Name :" + Name);
                    Console.Write("Enter Class and section :");
                    string Classion = Console.ReadLine();
                    sw.WriteLine("Class and section :" + Classion);
                    Console.Write("Your Information interd to the File Seccessfully");
                }
            }
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
    /////////////////////////////////

    public void updateData()
    {
        try
        {
            using (FileStream fs = new FileStream("//Users//shahadsh//Documents//project//teacherFile.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.Write("Enter the ID :");
                    string ID = Console.ReadLine();
                    sw.WriteLine("ID :" + ID);
                    Console.Write("Enter the Name :");
                    string Name = Console.ReadLine();
                    sw.WriteLine("Name :" + Name);
                    Console.Write("Enter Class and section :");
                    string Classion = Console.ReadLine();
                    sw.WriteLine("Class and section :" + Classion);
                    Console.Write("Your Information updated Seccessfully");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    /////////////////////////////////

    public void retrieveData()
    {
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream("//Users//shahadsh//Documents//project//teacherFile.txt", FileMode.Open, FileAccess.Read);

            sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {

                Console.WriteLine(str);
                str = sr.ReadLine();
            }
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sr.Close();
            fs.Close();
        }
    }

}


class Rainbow_School
{
    
    static void Main(string[] args)
    {
        char opt;
        do
        {
            Console.WriteLine("Welcom to Rainbow School");
            Console.WriteLine("1 - store a new teacher data");
            Console.WriteLine("2 - retrieve teacher data");
            Console.WriteLine("3 - update teacher data");
            Console.WriteLine("Select Option : ");
            int choice = int.Parse(Console.ReadLine());
            Opration opration = new Opration();
            switch (choice)
            {
                case 1:

                    opration.writeData();

                    Console.ReadKey();
                    break;
                /////////////
                case 2:
                    opration.retrieveData();

                    Console.ReadKey();
                    break;
                /////////////
                case 3:
                    opration.updateData();

                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Invalid Choice!!");
                    break;
            }
            Console.Write("Do you wish to Continue?(yes/No) : ");
            opt = char.Parse(Console.ReadLine());
        } while(opt == 'y' || opt == 'Y');

        Console.Write("Thank You");
    }
}

