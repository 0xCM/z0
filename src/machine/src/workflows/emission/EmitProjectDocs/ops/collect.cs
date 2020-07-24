
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial struct EmissionWorkflow 
    {
        partial struct EmitProjectDocs
        {
            public static Dictionary<PartId, Dictionary<string,string>> collect()
            {
                var docs = AppPaths.Default.ResourceRoot + FolderName.Define("docs");
                docs.Clear();
                var src = collect(KnownParts.Service.ComponentPaths.ToArray());
                var dst = new Dictionary<PartId, Dictionary<string,ProjectDocRecord>>();
                foreach(var part in src.Keys)
                {                                
                    var path = docs + FileName.Define(part.Format(), FileExtensions.Csv);
                    var partDocs = new Dictionary<string, ProjectDocRecord>();
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
        }
    }
}