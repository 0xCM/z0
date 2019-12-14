//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;
    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector256<ushort> vmerge(Vector128<ushort> x, Vector128<ushort> y, byte lo, byte hi)        
            => vconcat(Blend(x,y, lo), Blend(x,y, hi));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vmerge(Vector128<ushort> x, Vector128<ushort> y, Blend8x16 lo, Blend8x16 hi)        
            => vmerge(x,y, (byte)hi, (byte)lo);

        [MethodImpl(Inline)]
        public static Vector256<uint> vmerge(Vector128<uint> x, Vector128<uint> y, byte lo, byte hi)        
            => vconcat(Blend(x,y, lo), Blend(x,y, hi));

        [MethodImpl(Inline)]
        public static Vector256<uint> vmerge(Vector128<uint> x, Vector128<uint> y, Blend4x32 lo, Blend4x32 hi)        
            => vmerge(x,y, (byte)hi, (byte)lo);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vmerge(Vector128<ulong> x, Vector128<ulong> y, byte lo, byte hi)        
            => vconcat(vblend(x,y, lo), vblend(x,y,hi));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vmerge(Vector128<ulong> x, Vector128<ulong> y, Blend2x64 lo, Blend2x64 hi)        
            => vmerge(x,y, (byte)lo, (byte)hi);
    }

}