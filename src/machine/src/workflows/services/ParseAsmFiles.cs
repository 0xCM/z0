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

        readonly IWfShell Wf;

        readonly PartFiles Files;

        public ParseAsmFiles(IWfShell wf, PartFiles files, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Files = files;
            Wf.Created(StepId, Ct);
        }

        public void Run()
        {
            Wf.Running(StepId, Ct);

            try
            {
                var files = Files.Asm.View;
                var count = Files.Asm.Count;

                Wf.Status(StepId, count);

                for(var i=0u; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);
                    var result = TextDocParser.parse(path, TextDocFormat.Unstructured);
                    if(result.Succeeded)
                    {
                        var doc = result.Value;
                        Wf.Raise(new ParsedAsmFile(StepId, doc.RowCount, path, Ct));
                    }
                    else
                    {
                        Wf.Error(StepId, path);
                    }
                }

            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepId, Ct);
        }
    }
}