//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    
    public ref struct EmitHexLineFile
    {
        readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly IPart Part;

        readonly MemoryAddress Base;

        readonly FilePath TargetPath;

        readonly string DataType;

        MemoryAddress Offset;

        [MethodImpl(Inline)]
        public EmitHexLineFile(WfContext wf, IPart part, MemoryAddress @base, FilePath dst, CorrelationToken? ct = null)
        {
            Ct = correlate(ct);
            Wf = wf;
            Part = part;
            TargetPath = dst;
            DataType = "HexLine";
            Base = @base;
            Wf.Initialized(nameof(EmitHexLineFile), Ct);
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
            Wf.Finished(nameof(EmitHexLineFile), Ct);
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }
    }
}