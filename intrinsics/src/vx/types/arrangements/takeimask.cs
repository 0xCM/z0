//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        public readonly struct TakeIMask128<T> : IVUnaryScalar128Imm8<T,ushort>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public static HK.Vec128<T> hk => default;

            public static TakeIMask128<T> Op => default;

            public OpIdentity Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index) 
                => ginx.vtakemask(x,index);            
        }

        public readonly struct TakeIMask256<T>  : IVUnaryScalar256Imm8<T,uint>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public static HK.Vec256<T> hk => default;

            public static TakeIMask256<T> Op => default;
            
            public OpIdentity Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index) 
                => ginx.vtakemask(x,index);
        }    
    }
}