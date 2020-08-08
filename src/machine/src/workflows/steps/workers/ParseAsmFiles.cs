//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;
    using static ParseAsmFilesStep;
    
    public readonly ref struct ParseAsmFiles
    {
        readonly CorrelationToken Ct;

        readonly IWfContext Wf;

        readonly PartFiles Files;
        
        public ParseAsmFiles(IWfContext wf, PartFiles files, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Files = files;
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            Wf.Running(WorkerName, Ct);

            try
            {
                var files = z.span(Files.AsmFiles);
                var count = files.Length;

                Wf.Status(WorkerName, $"Parsing {count} asm files", Ct);
                for(var i=0u; i<count; i++)
                {
                    ref readonly var path = ref z.skip(files,i);
                    var result = TextDocParser.parse(path, TextDocFormat.Unstructured);
                    if(result.Succeeded)
                    {
                        var doc = result.Value;
                        Wf.Raise(new ParsedAsmFile(WorkerName, (uint)doc.RowCount, path, Ct));                         
                    }
                    else
                    {
                        Wf.Error(WorkerName, $"The document {path} failed to parse", Ct);                
                    }
                }            

            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(WorkerName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}