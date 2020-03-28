//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;

    partial class VSvcHosts
    {
        public readonly struct Lo128<T> : ISVUnaryOp128Api<T>
            where T : unmanaged
        {
            public const string Name = "vhi";

            public Vec128Kind<T> VKind => default;

            public static Lo128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vlo(x);            
        }

        public readonly struct Lo256<T> : ISVFReduder256Api<T>
            where T : unmanaged
        {
            public const string Name = "vlo";

            public Vec256Kind<T> VKind => default;

            public static Lo256<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector256<T> x) 
                => gvec.vlo(x);           
        }
    }
}