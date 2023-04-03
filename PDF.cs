using System;

namespace SecondLab {
  class PDF : Document {
    string DocumentPDFVersion;
    int DocumentPDFNumberOfPages;

    public PDF(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentTopic, string DocumentPath) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentTopic = DocumentTopic;
      this.DocumentPath = DocumentPath;

      Console.Write("Введите версию PDF файл: ");
      DocumentPDFVersion = Console.ReadLine();

      Console.WriteLine("Введите количество страниц: ");
      DocumentPDFNumberOfPages = Convert.ToInt32(Console.ReadLine());
    }
     
    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " + 
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nВерсия PDF: {DocumentPDFVersion}" +
        $"\nКоличество страниц: {DocumentPDFNumberOfPages}");
    }
  }
}