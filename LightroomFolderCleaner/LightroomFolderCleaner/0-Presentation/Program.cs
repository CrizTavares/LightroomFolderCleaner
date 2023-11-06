using LightroomFolderCleaner._2_Entities;

namespace LightroomFolderCleaner._0_Presentation
{
    public class LightroomFolderCleaner
    {
        static void Main() {
        
            Console.Write("Provide the directory path: ");
            string directory = Console.ReadLine();

            var FileList = Directory.GetFiles(directory);

            //List<File> photoFile = new List<File>();
            //List<File> rawFile = new List<File>();


            foreach (var item in FileList)
            {
                FileInfo fi = new FileInfo(item);
                Console.WriteLine(item);
                if (fi.Extension.ToUpper() == "CR3" || fi.Extension.ToUpper() == "GPR")
                {

                }

                if (fi.Extension.ToUpper() == "JPG" || fi.Extension.ToUpper() == "PNG")
                {

                }
            }
        }
    }

}
