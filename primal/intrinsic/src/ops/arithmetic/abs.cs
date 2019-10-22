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
        public static Vector128<byte> abs(Vector128<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> abs(Vector128<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<uint> abs(Vector128<int> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector128<long> abs(Vector128<long> src)
        {
            var mask = vnegate(vsrl(src, 63));                        
            return vsub(vxor(mask, src), mask);
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> abs(Vector256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector256<ushort> abs(Vector256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vector256<uint> abs(Vector256<int> src)
            => Abs(src);        
 
        [MethodImpl(Inline)]
        public static Vector256<long> abs(Vector256<long> src)
        {
            var mask = vnegate(vsrl(src, 63));
            return vsub(vxor(mask, src), mask);
        }
    }

}