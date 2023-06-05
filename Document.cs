using System;

namespace SecondLab {
  class Document {
    public string DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic;

    public virtual void DocumentInfo() {
      Console.WriteLine($"Имя файла: {DocumentName}\nАвтор: {DocumentAuthor}\n \n Ключевые слова: {DocumentKeyWords}\n" +
        $"Путь к файлу: {DocumentPath}\nТема: {DocumentTopic}\n");
    }
  }
}