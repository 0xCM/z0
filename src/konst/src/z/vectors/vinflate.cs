//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static z;

    partial struct z
    {        
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate(W128 w, in byte src)
            => ConvertToVector256Int16(z.vload(w, src)).AsUInt16();

        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate(W256 w, in byte src)
        {
           var lo = vinflate(z.vload(w128, src));
           var hi = vinflate(z.vload(w128, add(src,16)));
           return v512(lo,hi);
        }

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector128<byte> src)
            => ConvertToVector256Int16(src).AsUInt16();

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N0 lo)
            => vinflate(vlo(src));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N1 hi)
            => vinflate(vhi(src));
    }
}