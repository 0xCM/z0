//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitCilRecords
    {
        readonly IEmissionWorkflow Wf;

        readonly EmissionDataType DataType;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitCilRecords(IEmissionWorkflow wf, IPart[] parts, FolderPath dst)
        {
             Wf = wf;
             Parts = parts;
             DataType = EmissionDataType.Il;
             TargetDir = dst;
                PartDataEmitters.emitting(DataType, Wf);
        }

        public void Run()
        {
            foreach(var part in Parts)
            {
                using var emitter = new EmiPartCil(Wf, part, TargetDir + FileName.Define(part.Id.Format(), "il.csv"));
                emitter.Run();
            }                                     

        }

        public void Dispose()
        {
            PartDataEmitters.emitted(DataType, Wf);
        }            
    }
}