//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class FixedConvert
    {
        [MethodImpl(Inline)]
        public static ref readonly F From<T,F>(in T src)
            where F : unmanaged, IFixed
            where T : struct
                => ref Unsafe.As<T,F>(ref  Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static ref readonly F FromScalar<T,F>(in T src)
            where F : unmanaged, IFixed
            where T : struct
                => ref From<T,F>(in src);

        [MethodImpl(Inline)]
        public static ref readonly F FromVector<T,F>(in Vector128<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref From<Vector128<T>,F>(in src);

        [MethodImpl(Inline)]
        public static ref readonly F FromVector<T,F>(in Vector256<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref From<Vector256<T>,F>(in src);
        
        [MethodImpl(Inline)]
        public static ref readonly F FromVector<T,F>(in Vector512<T> src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => ref From<Vector512<T>,F>(in src);
    }

}