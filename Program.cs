using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

class Program
{
    public static void Main(string[] args)
    {
        string inputFilePath = "D:\\Codes\\dotnet\\PDFMaker\\PDFMaker\\Input.txt";

        //output file path
        string outputFilePath = "D:\\Codes\\dotnet\\PDFMaker\\PDFMaker\\Output.pdf";

        Document document = new Document();

        //creating pdf writer 
        PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(outputFilePath, FileMode.Create));

        document.Open(); // opening the document for writing the pdf

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                document.Add(new Paragraph(line));
            }
        }

        document.Close();
        pdfWriter.Close();
        System.Console.WriteLine("PDF Created Successfuly");

    }
}
