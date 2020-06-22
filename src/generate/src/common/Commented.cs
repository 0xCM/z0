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

    public readonly struct Commented
    {        

        public static Dictionary<PartId, Dictionary<string,string>> collect()
        {
            return collect(KnownParts.Service.ComponentPaths.ToArray());
        }

        public static Dictionary<PartId, Dictionary<string,string>> collect(FilePath[] paths)        
        {
            term.print($"Collecting documentation for {paths.Length} parts");

            var dst = new Dictionary<PartId, Dictionary<string,string>>();
            foreach(var path in paths)
            {
                var id = path.Owner;
                if(id.IsSome())
                {
                    var xmlfile = path.ChangeExtension(FileExtensions.Xml);
                    if(xmlfile.Exists)
                    {
                        var data = xmlfile.ReadText();
                        term.print($"Parsing {xmlfile}");
                        dst[id] = parse(data);
                    }
                }
                else
                    term.warn($"No owner discerned for {path}");

            }
            return dst;

        }
        public static Dictionary<string,string> parse(string src)
        {
            var docs = new Dictionary<string, string>();
            using var xmlReader = XmlReader.Create(new StringReader(src));
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "member")
                {
                    string raw_name = xmlReader["name"];
                    docs[raw_name] = xmlReader.ReadInnerXml();
                }
            }
            return docs;
        }        
    }
}