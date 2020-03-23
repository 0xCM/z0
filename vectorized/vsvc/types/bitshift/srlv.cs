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
        public readonly struct Srlv128<T> : ISVBinaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsrlv";

            public static VKT.Vec128<T> hk => default;

            public static Srlv128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

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

            public static VKT.Vec256<T> hk => default;

            public static Srlv256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> counts) 
                => gvec.vsrlv(x,counts);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T count) 
                => gmath.srl(a,convert<T,byte>(count));
        }
    }
}