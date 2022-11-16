# Read&Write

## Readlines

Readlines or files is too much easy

```cs
            // All file
            string text = System.IO.File.ReadAllText(@"C:\Users\super\Documents\csharp_topics\text.txt");
            Console.WriteLine("El archivo contiene: {0}", text);

            Console.WriteLine("+++++++++++++++++++++++");
            // Line for line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\super\Documents\csharp_topics\text.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("{0}", lines[i]);
            }

```

## Write

```cs
            // Basic way
            Console.WriteLine("Please, write some line: ");
            string line = Console.ReadLine();
            File.WriteAllText(@"C:\Users\super\Documents\csharp_topics\text.txt", line);

            // Other way
            Console.WriteLine("Please write the file name: ");
            string nameFile = Console.ReadLine();
            Console.WriteLine("Please write the information: ");
            line = Console.ReadLine();
            File.WriteAllText(@"C:\Users\super\Documents\csharp_topics\" + nameFile + ".txt", line);

            // Stream writer (no rewrite)
            using (StreamWriter file = new StreamWriter(@"C:\Users\super\Documents\csharp_topics\conditions.txt", true))
            {
                string[] allLines = { "Primera", "Segunda", "Tercera" };
                foreach (string lin in allLines)
                {
                    if (lin.Contains("T"))
                    {
                        file.WriteLine(lin);
                    }
                }
            }
```

## Extra ways to write or read files


```cs
try{
    string file = "C:\\puntonet\\temp.txt";
    FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
    StreamWriter sw = new StreamWriter(fs);
    sw.WriteLine("Hello");
    sw.Close();
} catch(DirectoryNotFoundException dnfe){
    Consol.WriteLine("ERROR: You should create the directory");
}
catch(IOException ioe){
    Console.WriteLine("ERROR: {0}", ioe.ToString());
}finally{
    Console.WriteLine("All is fine");
}
```
## [Return to index](/README.md)