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
        const string Sep = "| ";
        
        public static Dictionary<PartId, Dictionary<string,string>> collect()
        {
            var docs = AppPaths.Default.ResourceRoot + FolderName.Define("docs");
            var src = collect(KnownParts.Service.ComponentPaths.ToArray());
            foreach(var part in src.Keys)
            {                                
                var path = docs + FileName.Define(part.Format(), FileExtensions.Csv);
                using var dst = path.Writer();                

                var kvp = src[part];
                foreach(var key in kvp.Keys)
                {
                    var item = key.PadRight(50);
                    var value = kvp[key];
                    var line = text.concat(Sep, item, Sep, value);
                    dst.WriteLine(line);
                }
            }
            return src;
        }

        public static Dictionary<PartId, Dictionary<string,string>> collect(FilePath[] paths)        
        {
            term.print($"Examining {paths.Length} documentation files");

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
                        var parsed = parse(data);
                        if(parsed.Count != 0)
                        {
                            dst[id] = parsed;
                            term.print($"Parsed {dst[id].Count} entries from {xmlfile}");
                        }
                    }
                }

            }

            term.print($"Collected documentation for {dst.Count} parts");

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