using System.IO;
using System.Xml.Linq;

namespace DrucklaufCSharp.Classes
{
    abstract public class clsConfig
    {
        abstract protected void ReadElements(XElement XMLReader);

        public clsConfig(string Filename)
        {
            if (!File.Exists(Filename)) return;

            XElement XMLReader = XElement.Load(Filename);
            ReadElements(XMLReader);
        }
    }
}
