//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; using static Memories;

    partial class VSvcHosts
    {
        public readonly struct Srlv128<T> : ISVBinaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsrlv";

            public Vec128Kind<T> VKind => default;

            public static Srlv128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> counts) 
                => gvec.vsrlv(x,counts);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T count) 
                => gmath.srl(a,convert<T,byte>(count));            
        }

        public readonly struct Srlv256<T> : ISVBinaryOp256DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsrlv";

            public Vec256Kind<T> VKind => default;

            public static Srlv256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> counts) 
                => gvec.vsrlv(x,counts);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T count) 
                => gmath.srl(a,convert<T,byte>(count));
        }
    }
}