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

    partial class VSvcHosts
    {
        public readonly struct TakeMask128<T> : ISVUnaryScalar128Api<T,ushort>
            where T : unmanaged
        {
            public const string Name = "vtakemask";

            public static VKT.Vec128<T> hk => default;

            public static TakeMask128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x) 
                => gvec.vtakemask(x);            
        }

        public readonly struct TakeMask256<T> : ISVUnaryScalar256Api<T,uint>
            where T : unmanaged
        {
            public const string Name = "vtakemask";

            public static VKT.Vec256<T> hk => default;

            public static TakeMask256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x) 
                => gvec.vtakemask(x);
        }    
    }
}