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
        public readonly struct Sub128<T> : IVBinOp128D<T>, IBinaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vsub";

            public static VKT.Vec128<T> hk => default;

            public static Sub128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vsub(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.sub(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.vsub(a,b,c);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Sub256<T> : IVBinOp256D<T>, IBinaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vsub";

            public static VKT.Vec256<T> hk => default;

            public static Sub256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => gvec.vsub(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.sub(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.vsub(a,b,c);
        } 
    }
}