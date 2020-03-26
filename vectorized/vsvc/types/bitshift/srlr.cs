//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class VSvcHosts
    {
        public readonly struct Srlr128<T> : ISVBinaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsrlr";

            public Vec128Kind<T> VKind => default;

            public static Srlr128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> count) 
                => gvec.vsrlr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T count) 
                => gmath.srl(a,convert<T,byte>(count));            
        }

        public readonly struct Srlr256<T> : ISVBinaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsrlr";

            public Vec256Kind<T> VKind => default;

            public static Srlr256<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> count) 
                => gvec.vsrlr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.srl(a,convert<T,byte>(offset));
        }
    }
}