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
        public readonly struct Not128<T> : IVSvcUnaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vnot";

            public static Not128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vnot(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref VBlocks.not(a,c);
        }

        [NumericClosures(Integers)]
        public readonly struct Not256<T> : IVSvcUnaryOp256<T>
            where T : unmanaged
        {
            public const string Name = "vnot";

            public static Not256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vnot(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref VBlocks.vnot(a,c);
        }
   }
}