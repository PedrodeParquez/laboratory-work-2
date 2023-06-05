using System;

namespace SecondLab {
  class PDF : Document {
    string DocumentPDFVersion;
    int DocumentPDFNumberOfPages;

    public PDF(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentPath, string DocumentTopic) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;
      
      Console.Write("Введите версию PDF файл: ");
      DocumentPDFVersion = Console.ReadLine();

      Console.WriteLine("Введите количество страниц: ");
      DocumentPDFNumberOfPages = int.Parse(Console.ReadLine());
    }
     
    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\n + " + 
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nТема: {DocumentTopic}\n" +
        $"Версия PDF: {DocumentPDFVersion}\nКоличество страниц: {DocumentPDFNumberOfPages}");
    }
  }
}