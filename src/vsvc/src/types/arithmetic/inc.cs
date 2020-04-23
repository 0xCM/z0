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
        [NumericClosures(Integers)]
        public readonly struct Inc128<T> : ISVUnaryOp128D<T>, IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vinc";

            public Vec128Kind<T> VKind => default;

            public static Inc128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vinc(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref VBlocks.inc(a,c);
        }

        [NumericClosures(Integers)]
        public readonly struct Inc256<T> : ISVUnaryOp256D<T>, IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            public const string Name = "vinc";

            public Vec256Kind<T> VKind => default;

            public static Inc256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gvec.vinc(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref VBlocks.vinc(a,c);
        }            
    }
}