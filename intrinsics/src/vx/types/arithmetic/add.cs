//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Add128<T> : IVBinOp128D<T>, IBinaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public static VKT.Vec128<T> hk => default;

            public static Add128<T> Op => default;
             
            public OpIdentity Id => Identity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => ginx.vadd(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref vblocks.add(a,b,c);

        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Add256<T> : IVBinOp256D<T>, IBinaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public static VKT.Vec256<T> hk => default;

            public static Add256<T> Op => default;
            
            public OpIdentity Id => Identity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => ginx.vadd(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref vblocks.add(a,b,c);
        }
    }
}