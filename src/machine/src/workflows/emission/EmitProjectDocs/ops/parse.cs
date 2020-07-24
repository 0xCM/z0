
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.IO;

    partial struct EmissionWorkflow 
    {
        partial struct EmitProjectDocs
        {
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

            static ParseResult<ProjectDocRecord> parse(string key, string value)
            {
                var components = key.SplitClean(Chars.Colon); 
                if(components.Length == 2 && components[0].Length == 1)      
                {     
                    var k = kind(components[0][0]);
                    var name = components[1];
                    var summary = text.content(value, "<summary>", "</summary>").RemoveAny((char)AsciControl.CR, (char)AsciControl.NL).Trim();
                    return ParseResult.Success(key, new ProjectDocRecord(k, name, summary));                    
                }
                else
                    return ParseResult.Fail<ProjectDocRecord>(key);
            }
        }
    }
}