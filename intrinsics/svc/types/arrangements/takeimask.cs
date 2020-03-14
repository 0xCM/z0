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
        public readonly struct TakeIMask128<T> : IVUnaryScalar128Imm8<T,ushort>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public static VKT.Vec128<T> hk => default;

            public static TakeIMask128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index) 
                => gvec.vtakemask(x,index);            
        }

        public readonly struct TakeIMask256<T>  : IVUnaryScalar256Imm8<T,uint>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public static VKT.Vec256<T> hk => default;

            public static TakeIMask256<T> Op => default;
            
            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index) 
                => gvec.vtakemask(x,index);
        }    
    }
}