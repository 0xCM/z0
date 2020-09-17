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

    public readonly ref struct AsmFileParser
    {
        readonly IWfShell Wf;

        readonly PartFiles Files;

        readonly WfToolId Tool;

        public AsmFileParser(IWfShell wf)
        {
            Tool = typeof(AsmFileParser);
            Wf = wf;
            Wf.Created(Tool);
        }

        public void Dispose()
        {
            Wf.Disposed(Tool);
        }

        public void Parse(PartFiles src)
        {
            Wf.Running(Tool);

            try
            {
                var files = src.Asm.View;
                var count = src.Asm.Count;

                Wf.Status(Tool, count);

                for(var i=0u; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);
                    var result = TextDocParser.parse(path, TextDocFormat.Unstructured);
                    if(result.Succeeded)
                    {
                        var doc = result.Value;
                        Wf.Raise(new ParsedAsmFile(Tool, doc.RowCount, path, Wf.Ct));
                    }
                    else
                    {
                        Wf.Error(StepId, path);
                    }
                }

            }
            catch(Exception e)
            {
                Wf.Error(Tool, e);
            }

            Wf.Ran(Tool);
        }
    }
}