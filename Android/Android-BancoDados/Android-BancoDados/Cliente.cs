using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SQLite;

namespace Android_BancoDados
{
    public class Cliente
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public String Nome { get; set; }
    }
}