
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
    using static Commented;

    using static Konst;

    [WfHost]
    public sealed class EmitProjectDocsHost : WfHost<EmitProjectDocsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitProjectDocs(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitProjectDocs
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitProjectDocs(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);
            Commented.collect(Wf);
            Wf.Ran(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        const string Sep = "| ";

        static string format(SummaryComment src)
        {
            return text.concat(src.Kind.ToString().PadRight(12), Sep, src.Identifer.PadRight(70), Sep, src.Summary);
        }

        static DocTargetKind kind(char src)
            => src switch {
                'T' => DocTargetKind.Type,
                'M' => DocTargetKind.Method,
                'P' => DocTargetKind.Property,
                'F' => DocTargetKind.Field,
                _ => DocTargetKind.None,
            };

        Dictionary<PartId, Dictionary<string,string>> collect()
        {
            var docs = Wf.ResourceRoot + FolderName.Define("docs");
            docs.Clear();
            var src = collect(Wf.Modules.ManagedSources);
            var dst = new Dictionary<PartId, Dictionary<string,SummaryComment>>();
            foreach(var part in src.Keys)
            {
                var path = docs + FileName.define(part.Format(), FileExtensions.Csv);
                var partDocs = new Dictionary<string, SummaryComment>();
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

        Dictionary<PartId, Dictionary<string,string>> collect(FS.FilePath[] paths)
        {
            var dst = new Dictionary<PartId, Dictionary<string,string>>();
            foreach(var path in paths)
            {
                var id = path.Owner;
                if(id.IsSome())
                {
                    var xmlfile = path.ChangeExtension(FS.ext("xml"));
                    if(xmlfile.Exists)
                    {
                        var data = xmlfile.ReadText();
                        var parsed = parse(data);
                        if(parsed.Count != 0)
                        {
                            dst[id] = parsed;
                            Wf.Status(Host, $"Parsed {dst[id].Count} entries from {xmlfile}");
                        }
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
                var summary = text.content(value, "<summary>", "</summary>").RemoveAny((char)AsciControl.CR, (char)AsciControl.NL).Trim();
                return ParseResult.Success(key, new SummaryComment(k, name, summary));
            }
            else
                return ParseResult.Fail<SummaryComment>(key);
        }
    }
}