using System.Drawing;
using System.Drawing.Imaging;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Press any key to Start Screen Capture");
Console.ReadKey();

try
{
    var bitmap = new Bitmap(1024, 768, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
    var rec = new Rectangle(0, 0, 1024, 768);
    var graphic = Graphics.FromImage(bitmap);

    graphic.CopyFromScreen(rec.Left, rec.Top, 0, 0, rec.Size);
    bitmap.Save(@"C:\Users\arahk\source\repos\ScreenRecture\text.jpg", ImageFormat.Jpeg);

    Console.WriteLine("Capture Success");
}
catch (Exception ex)
{
    throw ex;
}

