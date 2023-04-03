using System;

namespace SecondLab {
  class TXT : Document {
    int DocumentTxtFileNumberOfRows, DocumentTxtFileNumberOfSymbols;
    
    public TXT(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentTopic, string DocumentPath) {
      this.DocumentName = DocumentName
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentTopic = DocumentTopic;
      this.DocumentPath = DocumentPath;

      Console.WriteLine("Введите количество символов: ");
      DocumentTxtFileNumberOfSymbols = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите количество строк: ");
      DocumentTxtFileNumberOfRows = Convert.ToInt32(Console.ReadLine());    
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nКоличество символов: {DocumentTxtFileNumberOfSymbols}" +
        $"\nКоличество строк: {DocumentTxtFileNumberOfRows}");
    }
  }
}