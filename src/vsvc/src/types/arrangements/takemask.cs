//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; using static Memories;

    partial class VSvcHosts
    {
        public readonly struct TakeMask128<T> : ISVUnaryScalar128Api<T,ushort>
            where T : unmanaged
        {
            public const string Name = "vtakemask";

            public Vec128Kind<T> VKind => default;

            public static TakeMask128<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x) 
                => gvec.vtakemask(x);            
        }

        public readonly struct TakeMask256<T> : ISVUnaryScalar256Api<T,uint>
            where T : unmanaged
        {
            public const string Name = "vtakemask";

            public Vec256Kind<T> VKind => default;

            public static TakeMask256<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x) 
                => gvec.vtakemask(x);
        }    
    }
}