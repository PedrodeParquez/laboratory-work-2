using System;

namespace SecondLab {
  class HTML : Document {
    int DocumentHTMLFileNumberOfRows, DocumentHTMLFileNumberOfSymbols;

    public HTML(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentPath, string DocumentTopic) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;
    
      Console.Write("Введите количество строк: ");
      DocumentHTMLFileNumberOfRows = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите количество символов: ");
      DocumentHTMLFileNumberOfSymbols = int.Parse(Console.ReadLine());
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $" Путь к файлу: {DocumentPath}\nКлючевые слова: {DocumentKeyWords}\nКоличество строк: {DocumentHTMLFileNumberOfRows}" +
        $"\nКоличество символов: {DocumentHTMLFileNumberOfSymbols}");
    }
  }
}