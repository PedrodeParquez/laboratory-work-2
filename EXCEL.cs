using System;

namespace SecondLab {
  class EXCEL : Document {
    int DocumentExcelFileNumberOfRows, DocumentExcelFileNumberOfColumns;

    public EXCEL(string DocumentName, string DocumentAuthor, string DocumentKeyWords, 
      string DocumentTopic, string DocumentPath) {
      this.DocumentName = DocumentName
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWords = DocumentKeyWords;
      this.DocumentTopic = DocumentTopic;
      this.DocumentPath = DocumentPath;

      Console.Write("Введите количество строк: ");
      DocumentExcelFileNumberOfRows = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Введите количество столбцов: ");
      DocumentExcelFileNumberOfColumns = Convert.ToInt32(Console.ReadLine());
    }

    public override void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentFile}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}\nКоличество строк: {DocumentExcelFileNumberOfRows}" +
        $"\nКоличество столбцов: {DocumentExcelFileNumberOfColumns}");
    }
  }
}