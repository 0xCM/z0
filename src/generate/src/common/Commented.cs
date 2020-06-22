//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.IO;

    using static Root;

    public class Commented
    {
        Dictionary<string, string> docs {get;}
            = new Dictionary<string, string>();
        
        public void Load(string xmlDocumentation)
        {

            using var xmlReader = XmlReader.Create(new StringReader(xmlDocumentation));
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "member")
                {
                    string raw_name = xmlReader["name"];
                    docs[raw_name] = xmlReader.ReadInnerXml();
                }
            }
        }        
    }
}