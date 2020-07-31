//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public ref struct EmitHexLineFile
    {
        readonly IAppContext Wf;

        readonly IPart Part;

        readonly MemoryAddress Base;

        readonly FilePath TargetPath;

        readonly EmissionDataType DataType;

        MemoryAddress Offset;

        [MethodImpl(Inline)]
        public EmitHexLineFile(IAppContext wf, IPart part, MemoryAddress @base, FilePath dst)
        {
            Wf = wf;
            Part = part;
            TargetPath = dst;
            DataType = EmissionDataType.PartDat;
            Base = @base;
            DataType.Emitting(Wf);
            Offset = default;
        }

        public void Run()
        {            
            using var emitter = new HexLineEmitter(Wf, Part, Base, TargetPath);
            emitter.Run();
            Offset = emitter.OffsetAddress;
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }
    }
}