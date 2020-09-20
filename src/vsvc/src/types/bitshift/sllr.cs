//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    partial class VServices
    {
        public readonly struct Sllr128<T> : IBinaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets)
                => gvec.vsllr(x,offsets);

            [MethodImpl(Inline)]
            public T Invoke(T a, T offset)
                => gmath.sll(a,convert<T,byte>(offset));
        }

        public readonly struct Sllr256<T> : IBinaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offset)
                => gvec.vsllr(x,offset);

            [MethodImpl(Inline)]
            public T Invoke(T a, T offset)
                => gmath.sll(a,convert<T,byte>(offset));
        }
    }
}