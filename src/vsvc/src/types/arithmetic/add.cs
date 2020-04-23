//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Seed;

    partial class VSvcHosts
    {
        [NumericClosures(AllNumeric)]
        public readonly struct Add128<T> : IVSvcBinaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public Vec128Kind<T> VKind => default;

            public static Add128<T> Op => default;
             
            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vadd(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref VBlocks.add(a,b,c);
        }

        [NumericClosures(AllNumeric)]
        public readonly struct Add256<T> : IVSvcBinaryOp256<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public Vec256Kind<T> VKind => default;

            public static Add256<T> Op => default;
            
            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => gvec.vadd(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref VBlocks.add(a,b,c);
        }
    }
}