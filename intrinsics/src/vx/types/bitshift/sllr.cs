//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class VFTypes
    {
        public readonly struct Sllr128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vsllr";

            public static VKT.Vec128<T> hk => default;

            public static Sllr128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) 
                => ginx.vsllr(x,offsets);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.sll(a,convert<T,byte>(offset));            
        }

        public readonly struct Sllr256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vsllr";

            public static VKT.Vec256<T> hk => default;

            public static Sllr256<T> Op => default;
             
            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offset) 
                => ginx.vsllr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.sll(a,convert<T,byte>(offset));
        }
    }
}