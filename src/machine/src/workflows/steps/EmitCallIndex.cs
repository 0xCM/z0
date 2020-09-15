//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static EmitCallIndexStep;
    using static z;

    public ref struct EmitCallIndex
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        public WfDataFlow<ApiPartRoutines,FilePath> Df;

        public EmitCallIndex(IWfShell wf, ApiPartRoutines src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Df = (src, (Wf.ResourceRoot + FolderName.Define("calls")) + FileName.define($"{src.Part.Format()}.calls", FileExtensions.Csv));
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, Df.Target);

            ApiInstructions instructions = Df.Source.Instructions;
            var sep = Chars.Pipe;
            using var writer = Df.Target.Writer();

            var calls = instructions.CallData;
            var delimited = calls.Select(x => Delimit(x.Rows, sep));
            var names = Delimit(AsmCallInfo.AspectNames, sep);
            writer.WriteLine(names);
            z.iter(delimited, writer.WriteLine);

            Wf.Ran(StepId, calls.Length);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        static string Delimit(string[] src, char delimiter)
        {
            var dst = text.build();
            var last = src.Length - 1;
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0)
                {
                    dst.Append(Chars.Space);
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }

                if(i != last)
                    dst.Append(src[i].PadRight(16));
                else
                    dst.Append(src[i]);
            }

            return dst.ToString();
        }
    }
}