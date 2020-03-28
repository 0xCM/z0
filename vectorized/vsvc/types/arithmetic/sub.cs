//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class VSvcHosts
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Sub128<T> : ISVBinaryOp128DApi<T>, ISBBinaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vsub";

            public Vec128Kind<T> VKind => default;

            public static Sub128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vsub(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.sub(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.sub(a,b,c);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Sub256<T> : ISVBinaryOp256DApi<T>, ISBBinaryOp256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsub";

            public Vec256Kind<T> VKind => default;

            public static Sub256<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => gvec.vsub(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.sub(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.sub(a,b,c);
        } 
    }
}