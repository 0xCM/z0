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
        public readonly struct Impl128<T> : ISVBinaryOp128DApi<T>, ISBBinaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vimpl";

            public static Impl128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vimpl(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.impl(a,b,c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Impl256<T> : ISVBinaryOp256DApi<T>, ISBBinaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vimpl";

            public static Impl256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.SFunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vimpl(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.impl(a,b,c);
        }
    }
}