using System.Xml.Linq;
using DrucklaufCSharp.Classes;
 

namespace DrucklaufCSharp
{
    class clsDrucklaufConfig : clsConfig
    {
        public clsDrucklaufConfig(string Filename) : base(Filename) { }

        #region Properties
            public string DB1ConnectionString { get; set; }
            public string DB3ConnectionString { get; set; }
        #endregion

        // Überschreibt die Methode in 'clsConfig'
        override protected void ReadElements(XElement XMLReader)
        {    
            DB1ConnectionString = XMLReader.Element("DB1ConnectionString").Value.Trim();
            DB3ConnectionString = XMLReader.Element("DB3ConnectionString").Value.Trim();
        }
    }
}
