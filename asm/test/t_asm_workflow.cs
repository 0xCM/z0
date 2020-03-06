//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    public class t_asm_workflow : t_asm<t_asm_workflow>
    {
        public void host_workflow()
        {
            var extractor = Context.HostExtractor();
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var decoder = Context.FunctionDecoder();
            var root = RootEmissionPaths.Define(DefaultDataDir).Clear();
            var format = Context.AsmFormat.WithSectionDelimiter();

            foreach(var catalog in Context.Compostion.Catalogs)   
            {
                foreach(var host in catalog.ApiHosts)
                {
                    var paths = HostEmissionPaths.Define(host.Path,root);
                    var extract = extractor.Extract(host);
                    foreach(var op in extract)
                        Claim.eq(op.Uri.HostPath, host.Path);
                        
                    var extractReport = OpExtractReport.Create(extract); 
                    extractReport.Save(paths.ExtractPath);

                    var parsed = parser.Parse(extract);
                    var parsedReport = ParsedOpReport.Create(parsed);                    
                    parsedReport.Save(paths.ParsedPath);
                    
                    var decoded = decoder.Decode(parsed);

                    using var writer = Context.AsmWriter(format, paths.DecodedPath);
                    writer.Write(decoded);
                }
            }
        }

    }
}