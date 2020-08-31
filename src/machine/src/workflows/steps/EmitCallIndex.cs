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
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        public WfDataFlow<PartAsmFx,FilePath> Df;

        public EmitCallIndex(IWfContext wf, PartAsmFx src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Df = (src, (Wf.ResourceRoot + FolderName.Define("calls")) + FileName.define($"{src.Part.Format()}.calls", FileExtensions.Csv));
            Wf.Created(StepName, Ct);
        }

        public void Run()
        {

            Wf.RunningT(StepName, Df.Target, Ct);

            var index = LocatedAsmFxList.create(Df.Source.Located.ToArray());
            var sep = Chars.Pipe;
            using var writer = Df.Target.Writer();

            var data = index.CallData.ToArray();
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