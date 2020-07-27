//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitHexLineFile
    {
        readonly IEmissionWorkflow Wf;

        readonly IPart Part;

        readonly FilePath TargetPath;

        readonly EmissionDataType DataType;

        [MethodImpl(Inline)]
        public EmitHexLineFile(IEmissionWorkflow wf, IPart part, FilePath dst)
        {
            Wf = wf;
            Part = part;
            TargetPath = dst;
            DataType = EmissionDataType.PartDat;
            DataType.Emitting(Wf);
        }


        public void Run()
        {
            var dst = Wf.PartDatDir + FileName.Define(Part.Id.Format(), "dat");
            using var emitter = new HexLineEmitter(Wf, Part, dst);
            emitter.Run();
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);
        }
    }
}