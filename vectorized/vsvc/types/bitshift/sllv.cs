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
        public readonly struct Sllv128<T> : ISVBinaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsllv";
             
            public Vec128Kind<T> VKind => default;

            public static Sllv128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) 
                => gvec.vsllv(x,offsets);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.sll(a,convert<T,byte>(offset));
        }

        public readonly struct Sllv256<T> : ISVBinaryOp256DApi<T>
            where T : unmanaged
        {
            public const string Name = "vsllv";
             
            public Vec256Kind<T> VKind => default;

            public static Sllv256<T> Op => default;
            
            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets) 
                => gvec.vsllv(x,offsets);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.sll(a,convert<T,byte>(offset));
        }
    }
}