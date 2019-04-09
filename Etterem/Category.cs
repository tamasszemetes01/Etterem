using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Etterem
{
    /// <summary>
    /// Az ételek Kategóriáját tartalmazó osztály
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Az adatbázisba írás miatt kell a Primary Key(PK) a táblába
        /// ezt hozza létre a property.Mivel Id a neve a Code first automatikusan 
        /// tudja hogy ő a PK.
        /// A név lehet Id és Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Az étel kategória neve
        /// </summary>
        public string Name { get; set; }
    }
}