using System.Drawing;

namespace Ecop.PL.Helpers
{
    public class FilesSetting
    {
        public static  string UploadFile(IFormFile file,string folderName) {

          
            string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);

            
          //يمكن يكون في ثنين برفعو ملفين بنفس الاسم بنفس الوقت ف بنعمل تشفير لنحلها 

            string fileName =$"{ Guid.NewGuid()}{ file.FileName}";
            
            string filepath=Path.Combine(folderpath,fileName);
            //هيك الباث صار جاهز يتخزن في داتا بيس

            //هون حكيتلو بدنا ننشا ملف في الباث لعملتو 
            var filestream=new FileStream(filepath,FileMode.Create);

            file.CopyTo(filestream);
            return fileName;
            //هيك جاهز للاضافة 
        }
      
        public static void DeleteFile(string fileName,string folderName)
        {
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
        }


    }
}
