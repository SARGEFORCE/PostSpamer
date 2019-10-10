using System;
using System.ComponentModel;

namespace PostSpamer.library.Entities
{
    public class Recipient : HumanEntity//, IDataErrorInfo
    {
        //public override string Name
        //{
        //    get => base.Name;
        //    set => base.Name = value;            
        //}
        //string IDataErrorInfo.Error => "";
        //string IDataErrorInfo.this[string PropertyName]
        //{
        //    get
        //    {
        //        switch (PropertyName)
        //        {
        //            default: return string.Empty;
        //            case nameof(Name):
        //                var name = Name;
        //                if(Name is null) return "Отсутсвует ссылка на строку с именем";
        //                if (Name.Length <= 3) return "Имя должно быть длиннее трех символов";
        //                if (!char.IsLetter(Name[0])) return "Имя должно начинаться с буквы";
        //                return string.Empty;
        //        }
        //    }
        //}
    }
}