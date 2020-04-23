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
    
    using K = Kinds;


    partial class VSvcHosts
    {
        [NumericClosures(AllNumeric)]
        public readonly struct Min128<T> : ISVBinaryOp128D<T>, IBlockedBinaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vmin";

            public Vec128Kind<T> VKind => default;

            public static Min128<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            public K.BinaryOpClass<T> Class => default;

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref VBlocks.min(a,b,c);

        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Min256<T> : ISVBinaryOp256D<T>, IBlockedBinaryOp256<T>
            where T : unmanaged
        {
            public const string Name = "vmin";
            
            public Vec256Kind<T> VKind => default;

            public static Min256<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref VBlocks.min(a,b,c);
        }
    }
}