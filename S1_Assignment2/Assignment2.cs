using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Assignement2
    {
        public class PhotoBookTest
        {
            public static void Main()
            {
                var photoBook = new PhotoBook();
                Console.WriteLine(photoBook.GetNumberPages());

                var newPhotoBook = new PhotoBook(24);
                Console.WriteLine(newPhotoBook.GetNumberPages());

                var largePhotobook = new BigPhotoBook();
                Console.WriteLine(largePhotobook.GetNumberPages());
            }
        }
        public class PhotoBook
        {
            protected int numPages {  get; set; }
            public PhotoBook() 
            {
                numPages = 16;
            }
            public PhotoBook(int numPages)
            {
                this.numPages = numPages;   
            }
            public int GetNumberPages()
            {
                return numPages;
            }
        }
        public class BigPhotoBook : PhotoBook
        {
            public BigPhotoBook() : base()
            {
                numPages = 64;
            }
        }
        


    }
}
