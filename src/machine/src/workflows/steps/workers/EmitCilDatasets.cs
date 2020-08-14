//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitCilDatasetsStep;

    using static z;
        
    [Step(WfStepKind.EmitCilDatasets)]
    public ref struct EmitCilDatasets
    {
        public readonly FolderPath TargetDir;

        public uint EmissionCount;
        
        public uint PartCount;

        readonly IPart[] Parts;

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;
     
        [MethodImpl(Inline)]
        public EmitCilDatasets(IWfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            PartCount = (uint)parts.Length;
            TargetDir = Wf.ResourceRoot + FolderName.Define(DataFolder);
            EmissionCount = 0;
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            Wf.RunningT(WorkerName, new {PartCount, TargetDir}, Ct);

            foreach(var part in Parts)
            {
                try
                {
                    EmissionCount += Emit(part, TargetDir + FileName.Define(part.Id.Format(), DatasetExt));
                }
                catch(Exception e)
                {
                    Wf.Error(e, Ct);
                }
            }                                     

            Wf.RanT(WorkerName, new {PartCount, TargetDir, EmissionCount}, Ct);
        }

        uint Emit(IPart part, FilePath dst)
        {
            Wf.Emitting(WorkerName, DataType, dst, Ct);

            var id = part.Id;
            var assembly = part.Owner;                
            var methods = PeMetaReader.methods(FilePath.Define(assembly.Location));
            var count = (uint)methods.Length;
            
            using var writer = dst.Writer();       
            writer.WriteLine(ImgMethodBody.Header);      

            for(var i=0u; i<count; i++)
                writer.WriteLine(skip(methods,i).Format()); 
            
            Wf.Emitted(WorkerName, DataType, count, dst, Ct);

            return count;
        }             

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }            
    }
}