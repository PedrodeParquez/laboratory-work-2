using System;

namespace SecondLab {
  class HTML : Document {
    int DocumentHTMLFileNumberOfRows, DocumentHTMLFileNumberOfSymbols;

    public HTML(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentTopic, string DocumentPath) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentTopic = DocumentTopic;
      this.DocumentPath = DocumentPath;

      Console.Write("Введите количество строк: ");
      DocumentHTMLFileNumberOfRows = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Введите количество символов: ");
      DocumentHTMLFileNumberOfSymbols = Convert.ToInt32(Console.ReadLine());
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nКоличество строк: {DocumentHTMLFileNumberOfRows}" +
        $"\nКоличество символов: {DocumentHTMLFileNumberOfSymbols}");
    }
  }
}