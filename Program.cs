using System; 

namespace SecondLab {
  public class Singleton {
    public static Singleton Instance {
      get {
        if (instance == null) instance = new Singleton();
        return instance;
      }
    }

    private static Singleton instance;

    string DocumentName, DocumentAuthor,
      DocumentKeyWords, DocumentPath, DocumentTopic;

    enum Formats {
      WORD = 1, EXCEL, PDF, TXT, HTML
    }
    public void DataInput() {
      Console.Write("Выберите формат файла:\n1. WORD\n2. EXCEL\n3. PDF\n" +
        "4. TXT\n5. HTML\nВаш формат под номером:");
      int UserChoice = int.Parse(Console.ReadLine());

      Console.Write("Введите Имя файла: ");
      DocumentName = Console.ReadLine();

      Console.Write("Введите автора: ");
      DocumentAuthor = Console.ReadLine();

      Console.Write("Введите ключевые слова (через пробел): ");
      DocumentKeyWords = Console.ReadLine();

      Console.Write("Введите путь к файлу: ");
      DocumentPath = Console.ReadLine();

      Console.Write("Введите основную тему файла: ");
      DocumentTopic = Console.ReadLine();

      switch (UserChoice) {
        case (int)Formats.WORD:
          WORD DocumentWORD = new WORD(DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic);
          DocumentWORD.DocumentInfo();
          break;
        case (int)Formats.EXCEL:
          EXCEL DocumentEXCEL = new EXCEL(DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic);
          DocumentEXCEL.DocumentInfo();
          break;
        case (int)Formats.PDF:
          PDF DocumentPDF = new PDF(DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic);
          DocumentPDF.DocumentInfo();
          break;
        case (int)Formats.TXT:
          TXT DocumentTXT = new TXT(DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic);
          DocumentTXT.DocumentInfo();
          break;
        case (int)Formats.HTML:
          HTML DocumentHTML = new HTML(DocumentName, DocumentAuthor, DocumentKeyWords, DocumentPath, DocumentTopic);
          DocumentHTML.DocumentInfo();
          break;
        default:
          Console.WriteLine("Некорректный ввод! Повторите попытку!");
          DataInput();
          break;
      }
    }
  }  
  class Program {
    static void Main() {
      Singleton.Instance.DataInput();
      Console.ReadKey();
    }
  }
}