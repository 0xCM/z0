//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Registers;

    partial struct CpuState
    {
        public ref xmm0 xmm0
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(v<xmm0>(), xmm0.Index*2);
        }

        public ref xmm1 xmm1
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(v<xmm1>(), xmm1.Index*2);
        }    

        public ref xmm2 xmm2
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(v<xmm2>(), xmm2.Index*2);
        }    

    }
}