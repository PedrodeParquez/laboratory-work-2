using System;

namespace SecondLab {
  class EXCEL : Document {
    int DocumentExcelFileNumberOfRows, DocumentExcelFileNumberOfColumns;

    public EXCEL(string DocumentName, string DocumentAuthor, string DocumentKeyWords,
      string DocumentPath, string DocumentTopic) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.Write("Введите количество строк: ");
      DocumentExcelFileNumberOfRows = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите количество столбцов: ");
      DocumentExcelFileNumberOfColumns = int.Parse(Console.ReadLine());
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nКоличество строк: {DocumentExcelFileNumberOfRows}" +
        $"\nКоличество столбцов: {DocumentExcelFileNumberOfColumns}");
    }
  }
}