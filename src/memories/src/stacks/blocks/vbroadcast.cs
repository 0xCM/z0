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
 
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial class SymBits
    {        
        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vbroadcast(W128 w, ushort src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vbroadcast(W256 w, ushort src)
            => BroadcastScalarToVector256(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector512<byte> vbroadcast(W512 w, byte src)
            => (BroadcastScalarToVector256(&src),BroadcastScalarToVector256(&src));

        [MethodImpl(Inline)]
        public static unsafe Vector512<ushort> vbroadcast(W512 w, ushort src)
            => (BroadcastScalarToVector256(&src),BroadcastScalarToVector256(&src));
    }
}