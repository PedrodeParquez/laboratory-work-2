using System;

namespace SecondLab {
  class Document {
    public string DocumentName, DocumentAuthor, DocumentKeyWords, DocumentTopic, DocumentPath;

    public virtual void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\nТема: {DocumentTopic} + " +
        $"Ключевые слова: {DocumentKeyWords}\nПуть к файлу: {DocumentPath}");
    }
  }
}