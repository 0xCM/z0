//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    using Z0.Asm;
    
    public delegate void CpuidProcessStep(Vector128<byte> src);
 
    [ApiHost]
    public readonly struct AsmProcessors
    {
        public static AsmProcessors Service => default;
        
        public asci16 Process(ReadOnlySpan<CpuidFeature> src, CpuidProcessStep step)
            => CpuidProcessor.Service.Process(src,step ?? OnStep);        
        
        [Op]
        public ProcessAsm Parsed(WfState wf)
            => ProcessAsm.create(wf);
        
        static void OnStep(Vector128<byte> src) 
        {

        }        
    }
}