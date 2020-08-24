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
    using static AnalyzeCallsStep;
    using static z;

    public ref struct AnalyzeCalls
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly LocatedAsmFxList Source;

        readonly FilePath DstPath;

        public AnalyzeCalls(IWfContext wf, LocatedAsmFxList src, FilePath dst, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Source = src;
            DstPath = dst;
            Wf.Created(StepName, Ct);
        }

        public void Run()
        {

            Wf.RunningT(StepName, DstPath, Ct);

            var sep = Chars.Pipe;
            using var writer = DstPath.Writer();

            var data = Source.CallData.ToArray();
            var delimited = data.Select(x => Delimit(x.Rows, sep));

            var names = Delimit(AsmCallInfo.AspectNames, sep);
            writer.WriteLine(names);
            z.iter(delimited, writer.WriteLine);

            Wf.RanT(StepName, names.Length, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName,Ct);
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