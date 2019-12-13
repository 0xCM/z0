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

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;    

    partial class dinx
    {    
        [MethodImpl(Inline)]
        public static Vector128<byte> vabs(Vector128<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vabs(Vector128<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<uint> vabs(Vector128<int> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<long> vabs(Vector128<long> src)
        {
            var mask = vnegate(vsrl(src, 63));                        
            return vsub(vxor(mask, src), mask);
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vabs(Vector256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vabs(Vector256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector256<uint> vabs(Vector256<int> src)
            => Abs(src);        
 
        [MethodImpl(Inline)]
        public static Vector256<long> vabs(Vector256<long> src)
        {
            var mask = vnegate(vsrl(src, 63));
            return vsub(vxor(mask, src), mask);
        }
    }
}