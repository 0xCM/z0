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
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Inc128<T> : ISVUnaryOp128DApi<T>, IUnaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vinc";

            public static VKT.Vec128<T> hk => default;

            public static Inc128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vinc(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref gblocks.vinc(a,c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Inc256<T> : ISVUnaryOp256DApi<T>, IUnaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vinc";

            public static VKT.Vec256<T> hk => default;

            public static Inc256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gvec.vinc(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref gblocks.vinc(a,c);
        }            
    }
}