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

    partial struct DevProjects
    {
        public readonly struct CommentCollector
        {
            public static Dictionary<PartId, Dictionary<string,string>> collect(IWfShell wf)
            {
                var dir = wf.Db().TableDir<SummaryComment>();
                var src = collect(wf, wf.ApiParts.ManagedSources);
                var dst = new Dictionary<PartId, Dictionary<string,SummaryComment>>();
                foreach(var part in src.Keys)
                {
                    var path = wf.Db().Table<SummaryComment>(part);
                    var docs = new Dictionary<string, SummaryComment>();
                    dst[part] = docs;
                    using var writer = path.Writer();

                    var kvp = src[part];
                    foreach(var key in kvp.Keys)
                    {
                        var member = parse(key, kvp[key]).OnSuccess(d => docs[d.Identifer] = d);
                        if(member.Succeeded)
                            writer.WriteLine(format(member.Value));
                    }
                    wf.EmittedTable<SummaryComment>(kvp.Count, path);
                }
                return src;
            }

            const string Sep = "| ";

            public static CommentTargetKind kind(char src)
                => src switch {
                    'T' => CommentTargetKind.Type,
                    'M' => CommentTargetKind.Method,
                    'P' => CommentTargetKind.Property,
                    'F' => CommentTargetKind.Field,
                    _ => CommentTargetKind.None,
                };

            public static string format(SummaryComment src)
                => text.concat(src.Kind.ToString().PadRight(12), Sep, src.Identifer.PadRight(70), Sep, src.Summary);

            static Dictionary<PartId, Dictionary<string,string>> collect(IWfShell wf, FS.FilePath[] paths)
            {
                var dst = new Dictionary<PartId, Dictionary<string,string>>();
                var t = default(SummaryComment);
                foreach(var path in paths)
                {
                    var id = path.Owner;
                    if(id.IsSome())
                    {
                        var xmlfile = path.ChangeExtension(FileExtensions.Xml);
                        if(xmlfile.Exists)
                        {
                            var flow = wf.Processing(xmlfile, "Processing XML documentation comment file");
                            var data = xmlfile.ReadText();
                            var parsed = parse(data);
                            if(parsed.Count != 0)
                                dst[id] = parsed;

                            wf.Processed(flow, path, t, parsed.Count);
                        }
                    }
                }
                return dst;
            }

            static Dictionary<string,string> parse(string src)
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

            static ParseResult<SummaryComment> parse(string key, string value)
            {
                var components = key.SplitClean(Chars.Colon);
                if(components.Length == 2 && components[0].Length == 1)
                {
                    var k = kind(components[0][0]);
                    var name = components[1];
                    var summary = TextRules.Parse.unfence(value, "<summary>", "</summary>").RemoveAny((char)AsciControl.CR, (char)AsciControl.LF).Trim();
                    return ParseResult.win(key, new SummaryComment(k, name, summary));
                }
                else
                    return ParseResult.fail<SummaryComment>(key);
            }
        }
    }
}