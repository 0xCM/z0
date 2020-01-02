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
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsign(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> vsign(Vector128<short> lhs, Vector128<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> vsign(Vector128<int> lhs, Vector128<int> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsign(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<short> vsign(Vector256<short> lhs, Vector256<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> vsign(Vector256<int> lhs, Vector256<int> rhs)
            => Sign(lhs, rhs);


    }
}