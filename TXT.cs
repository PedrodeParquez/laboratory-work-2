using System;

namespace SecondLab {
  class TXT : Document {
    int DocumentTxtFileNumberOfRows, DocumentTxtFileNumberOfSymbols;
    
    public TXT(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentPath, string DocumentTopic) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество символов: ");
      DocumentTxtFileNumberOfSymbols = int.Parse(Console.ReadLine());

      Console.Write("Введите количество строк: ");
      DocumentTxtFileNumberOfRows = int.Parse(Console.ReadLine());    
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Путь к файлу: {DocumentPath}\nКлючевые слова: {DocumentKeyWords}\n" +
        $"Количество символов: {DocumentTxtFileNumberOfSymbols}\nКоличество строк: {DocumentTxtFileNumberOfRows}");
    }
  }
}