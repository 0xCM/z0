//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public delegate void CpuidProcessStep(Vector128<byte> src);
 
    public readonly struct AsmProcessors
    {
        public static AsmProcessors Service => default;
        
        public asci16 Process(ReadOnlySpan<CpuidFeature> src, CpuidProcessStep step)
            => CpuidProcessor.Service.Process(src,step ?? OnStep);
        
        [MethodImpl(Inline)]
        public AsmCmdProcessor Parsed(IAsmContext context)
            => AsmCmdProcessor.Service(context);
        
        static void OnStep(Vector128<byte> src) {}
        
    }
}