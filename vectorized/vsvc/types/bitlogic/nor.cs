//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Core;

    partial class VSvcHosts
    {        
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nor128<T> : ISVBinaryOp128DApi<T>, ISBBinaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vnor";

            public static Nor128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vnor(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.nor(a,b,c);

        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nor256<T> : ISVBinaryOp256DApi<T>, ISBBinaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vnor";

            public static Nor256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vnor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.nor(a,b,c);
        }
    }
}