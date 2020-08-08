//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static Konst;
    using static EmitPeHeadersStep;

    using F = PeHeaderField;
    
    [Step(WfStepKind.EmitPeHeaders)]
    public readonly ref struct EmitPeHeaders
    {
        readonly IWfContext Wf;
        
        readonly IPart[] Parts;
        
        readonly FilePath TargetPath;
        
        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]        
        public EmitPeHeaders(IWfContext wf, IPart[] src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = src;
            TargetPath = wf.AppPaths.ResourceRoot + FileName.Define("z0", "pe.csv");
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            var pCount = Parts.Length;
            var total = 0u;
            Wf.RunningT(WorkerName,new {PartCount = pCount}, Ct);

            var formatter = DatasetFormatter<F>.Default;            
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;                                
                var records = PeMetaReader.headers(FilePath.Define(assembly.Location));
                var count = (uint)records.Length;
                
                for(var i=0; i<count; i++)
                {
                    format(z.skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                } 
                total += count;
            }  

            Wf.RanT(WorkerName, new {PartCount = pCount, TotalRecordCount = total}, Ct);
        }

        static void format(in PeHeaderRecord src, IDatasetFormatter<F> dst)
        {
            dst.Append(F.FileName, src.FileName);
            dst.Delimit(F.Section, src.Section);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Size, src.Size);
            dst.Delimit(F.EntryPoint, src.EntryPoint);
            dst.Delimit(F.CodeBase, src.CodeBase);
            dst.Delimit(F.Gpt, src.GlobalPointerTable);
            dst.Delimit(F.GptSize, src.GlobalPointerTableSize);
        }

        public void Dispose()
        {
            Wf.Finished(nameof(EmitPeHeaders), Ct);
        }
    }
}