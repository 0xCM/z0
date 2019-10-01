//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;
    using static As;

    partial class Asm
    {
        [MethodImpl(Inline)]
        public static XMM pxor(XMM xmm0, XMM xmm1)        
            => XMM.From(Xor(vload<ulong>(ref xmm0), vload<ulong>(ref xmm1)));        

        [MethodImpl(Inline)]
        public static YMM vpxor(YMM ymm0, YMM ymm1)        
            => YMM.From(Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1)));        

        [MethodImpl(Inline)]
        public static ref YMM vpxor(YMM ymm0, YMM ymm1, ref YMM ymm2)        
        {   
            ymm2  = YMM.From(Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1)));
            return ref ymm2;
        }        

        [MethodImpl(Inline)]
        public static ref Vec256<ulong> vpxor(YMM ymm0, YMM ymm1, out Vec256<ulong> ymm2)        
        {
            ymm2 = Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));        
            return ref ymm2;
        }            
 
    }
}