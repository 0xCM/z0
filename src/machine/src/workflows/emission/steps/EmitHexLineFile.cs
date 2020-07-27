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
        readonly IWfPartEmission Wf;

        readonly IPart Part;

        readonly FilePath TargetPath;

        readonly EmissionDataType DataType;

        [MethodImpl(Inline)]
        public EmitHexLineFile(IWfPartEmission wf, IPart part)
        {
            Wf = wf;
            Part = part;
            TargetPath = wf.PartDatDir + FileName.Define(part.Format(), FileExtension.Define("dat"));
            DataType = EmissionDataType.PartDat;
            DataType.Emitting(Wf);
        }


        public void Run()
        {
            using var emitter = new EmitHexLines(Wf, Part);
            emitter.Run();
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);
        }
    }
}