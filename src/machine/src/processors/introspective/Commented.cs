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
    using System.Reflection;
    using System.IO;

    public enum DocTargetKind
    {
        None = 0,

        Type = 1,

        Method = 2,

        Field = 3,

        Property = 4,
    }

    public readonly struct MemberDocs
    {
        public readonly DocTargetKind MemberKind {get;}

        public readonly string Identifer {get;}
        
        public readonly string Summary {get;}
        
        public MemberDocs(DocTargetKind kind, string identifier, string summary)
        {
            MemberKind = kind;
            Identifer = identifier;
            Summary = summary;
        }

        
    }

    public readonly struct Commented
    {        
        const string Sep = "| ";
        
        public static Dictionary<PartId, Dictionary<string,string>> collect()
        {
            var docs = AppPaths.Default.ResourceRoot + FolderName.Define("docs");
            docs.Clear();
            var src = collect(KnownParts.Service.ComponentPaths.ToArray());
            var dst = new Dictionary<PartId, Dictionary<string,MemberDocs>>();
            foreach(var part in src.Keys)
            {                                
                var path = docs + FileName.Define(part.Format(), FileExtensions.Csv);
                var partDocs = new Dictionary<string, MemberDocs>();
                dst[part] = partDocs;
                using var writer = path.Writer();                

                var kvp = src[part];
                foreach(var key in kvp.Keys)
                {
                    var member = parse(key, kvp[key])
                                .OnSuccess(d => partDocs[d.Identifer] = d);
                    if(member.Succeeded)                                
                    {
                        var line = format(member.Value);                        
                        writer.WriteLine(line);
                    }
                                
                }
            }
            return src;
        }

        static string format(MemberDocs src)
        {
            return text.concat(src.MemberKind.ToString().PadRight(12), Sep, src.Identifer.PadRight(70), Sep, src.Summary);   
        }

        static ParseResult<MemberDocs> parse(string key, string value)
        {
            var components = key.SplitClean(Chars.Colon); 
            if(components.Length == 2 && components[0].Length == 1)      
            {     
                var k = kind(components[0][0]);
                var name = components[1];
                var summary = text.enclosed(value, "<summary>", "</summary>").RemoveAny((char)AsciControl.CR, (char)AsciControl.NL).Trim();
                return ParseResult.Success(key, new MemberDocs(k, name, summary));                    
            }
            else
                return ParseResult.Fail<MemberDocs>(key);
        }

        static DocTargetKind kind(char src)
            => src switch {
                'T' => DocTargetKind.Type,
                'M' => DocTargetKind.Method,
                'P' => DocTargetKind.Property,
                'F' => DocTargetKind.Field,
                _ => DocTargetKind.None,
            };

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
            var index = new Dictionary<string, string>();
            using var xmlReader = XmlReader.Create(new StringReader(src));
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "member")
                {
                    string raw_name = xmlReader["name"];
                    index[raw_name] = xmlReader.ReadInnerXml();
                }
            }
            return index;
        }        
    }
}