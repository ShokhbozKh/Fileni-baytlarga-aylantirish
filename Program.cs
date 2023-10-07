namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string path = @"D://hello";
            //// Directory.CreateDirectory(path);
            // Console.WriteLine(Directory.GetParent(path));



            // var papka = Directory.EnumerateFileSystemEntries(path);
            // foreach(var  papkaEntry in papka)
            // {
            //     Console.WriteLine(papkaEntry);
            // }

            //string path = @"D://Hello.txt";
            //FileInfo fileInfo = new FileInfo(path);

            //if(!fileInfo.Exists)
            //{
            //    fileInfo.Create();

            //}
            //StreamWriter streamWriter = fileInfo.AppendText();
            //for(int i = 0; i < 12; i++)
            //{
            //    streamWriter.WriteLine(i);

            //}
            //streamWriter.Close();

            string path = @"D://folder";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.Create();

            string path2 = @"D:/folder/music.M4A";// file joyi
            byte[] buffer = File.ReadAllBytes(path2);// fileni baytlarga utkazib yozish
            Array.Reverse(buffer);//massivni teskari ugirish
            File.WriteAllBytes(path2, buffer);// qayta yozish
            Console.WriteLine($"BAytlar soni: {buffer.Length}");





        }
    }
}