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
        public readonly struct Pop128<T> : ISVTernaryScalar128DApi<T,uint>
            where T : unmanaged
        {
            public const string Name = "vpop";

            public static Pop128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public uint Invoke(Vector128<T> x,Vector128<T> y,Vector128<T> z) => gvec.vpop(x,y,z);
            
            [MethodImpl(Inline)]
            public uint InvokeScalar(T a, T b, T c) => gbits.pop(a,b,c);
        }

        public readonly struct Pop256<T> : ISVTernaryScalar256DApi<T,uint>
            where T : unmanaged
        {
            public const string Name = "vpop";

            public static Pop256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,Vector256<T> y,Vector256<T> z) => gvec.vpop(x,y,z);

            [MethodImpl(Inline)]
            public uint InvokeScalar(T a, T b, T c) => gbits.pop(a,b,c);
        }    
    }
}