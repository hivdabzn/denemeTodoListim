using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_
{
   public class TodoItem
    {
        public static List<string>
            YapılacaklarListesi = new List<string>();

        public static List<string>
           TamamlananlarListesi = new List<string>();

        public Guid Id { get; set; }
        public string GorevMetni{ get; set; }
        public DateTime TamamlanmaTarihi { get; set; }
        public bool Tamamlandi{ get; set; }

        public override string ToString()
        {
            if(!Tamamlandi)
                 return GorevMetni;
            else
                return TamamlanmaTarihi.ToShortDateString() + " " + GorevMetni;
        }


    }
}
