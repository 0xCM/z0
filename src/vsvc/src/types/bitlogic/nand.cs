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
    using static Memories;

    partial class VSvcHosts
    {
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nand128<T> : IVSvcBinaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vnand";

            public static Nand128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vnand(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.nand(a,b,c);

        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nand256<T> : ISVBinaryOp256DApi<T>, ISBBinaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vnand";

            public static Nand256<T> Op => default;

            public Vec256Kind<T> VKind => default;
            
            public OpIdentity Id => Identities.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vnand(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.nand(a,b,c);
        }
    }
}