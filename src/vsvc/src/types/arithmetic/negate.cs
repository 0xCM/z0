//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        [NumericClosures(AllNumeric)]
        public readonly struct Negate128<T> : ISVUnaryOp128DApi<T>, ISBUnaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vnegate";

            public Vec128Kind<T> VKind => default;

            public static Negate128<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vnegate(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.negate(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref gblocks.negate(a,c);
        }

        [NumericClosures(AllNumeric)]
        public readonly struct Negate256<T> : ISVUnaryOp256DApi<T>, ISBUnaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vnegate";

            public Vec256Kind<T> VKind => default;

            public static Negate256<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) 
                => gvec.vnegate(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.negate(a);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref gblocks.negate(a,c);
        }
    }
}