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
        readonly WfStepKind Id;
        
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly LocatedInstructions Source;

        readonly FolderPath TargetDir;
        
        public AnalyzeCalls(IWfContext wf, LocatedInstructions src, FolderPath dst, CorrelationToken ct)
        {
            Id = WfStepKind.AnalyzeCalls;
            Wf = wf;
            Ct = ct;
            Source = src;
            TargetDir = dst;
            Wf.Created(StepName, Ct);
        }

        public void Run()
        {
            Wf.Running(StepName, Ct);        

            var sep = Chars.Pipe;
            var filename = FileName.Define("Calls", FileExtensions.Csv);
            var path = TargetDir + filename;
            using var writer = path.Writer();

            var data = Source.CallData.ToArray();
            var delimited = data.Select(x => Delimit(x.Rows, sep));

            var names = Delimit(CallInfo.AspectNames, sep);            

            writer.WriteLine(names);
            Root.iter(delimited, writer.WriteLine);

            Wf.Ran(StepName, Ct);        
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