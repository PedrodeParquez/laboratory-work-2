using System;

namespace SecondLab {
  class WORD : Document {
    string DocumentWordPageCount, DocumentWordUsedFonts;

    public WORD(string DocumentName, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentName = DocumentName;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество страниц: ");
      DocumentWordPageCount = Console.ReadLine();

      Console.WriteLine("Введите используемые шрифты: ");
      DocumentWordUsedFonts = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество страниц: {DocumentWordPageCount}\n" +
        $"Используемые шрифты: {DocumentWordUsedFonts}");
    }
  }
}