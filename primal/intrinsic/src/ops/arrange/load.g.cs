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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static As;
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {        

        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
                => ref vloadu(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vload<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
                => ref vloadu(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vload<T>(N128 n, in T src)
            where T : unmanaged                    
                => vloadu(constptr(in src), out Vector128<T> _);
        
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vload<T>(N256 n, in T src)
            where T : unmanaged
                => vloadu(constptr(in src), out Vector256<T> _);
    }
}
