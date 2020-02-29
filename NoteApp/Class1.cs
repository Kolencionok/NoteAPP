using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Class1
    {

    }
}


/// <summary>
/// Перечисление. Категория заметки.
/// </summary>
public enum NoteCategory
{
    Работа,
    Дом, 
    Здоровье_и_Спорт,                                     /*как разделить?*/
    Люди,
    Документы,
    Финансы,
    Разное
}

/// <summary>
/// Класс, содержащий все сведения о заметке.
/// </summary>
/// <param name= "_name">Название заметки. Не более 50 символов.</param>
/// <param name="_category">Категория заметки (с.м. enum NoteCategory).</param>
/// <param name="_text">Текст, содержание заметки.</param>
/// <param name="_creatre_date">Дата созания заметки, инициализируется однажды - при создании.</param>
/// <param name="_last_change_date">Время последнего изменения меняется автоматически при изменении названия, категории или текста заметки.</param>
public class Note
{
    private string _name;
    private string _category;
    private string _text;
    private string _creature_date; /*какой тип данных? мб использовать перчисление?*/
    private string _last_chahge_date; /*какой тип данных? мб использовать перчисление?*/

    /// <summary>
    /// Метод, возвращающий значение имени заметки
    /// </summary>

    public string GetName()
    {
        return _name;
    }

    /// <summary>
    /// Метод, устанавливающий значение имени заметки. Имя не должно превышать 50 символов.
    /// По умолчанию заметка имеет имя "Без названия".
    /// </summary>
    public void SetName(string ValueName)
    {
        if (ValueName.Length > 50)
        {
            throw new ArgumentException();
            Console.Write("Имя не должно превышать 50 символов");
            if (ValueName.Length == 0)
            {
                _name = "Без названия";
            }
        }
        else
        {
            _name = ValueName;
        }

    }

    public string GetCategory()
    {
        return _category;
    }
    /*public void SetCategory()*/
}


