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
        readonly WfContext Wf;

        readonly IPart Part;

        readonly MemoryAddress Base;

        readonly FilePath TargetPath;

        readonly EmissionDataType DataType;

        MemoryAddress Offset;

        [MethodImpl(Inline)]
        public EmitHexLineFile(WfContext wf, IPart part, MemoryAddress @base, FilePath dst)
        {
            Wf = wf;
            Part = part;
            TargetPath = dst;
            DataType = EmissionDataType.PartDat;
            Base = @base;
            Wf.Running(nameof(EmitHexLineFile));
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
            Wf.Ran(nameof(EmitHexLineFile));
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }
    }
}