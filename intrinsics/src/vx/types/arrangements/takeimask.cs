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
            public static TakeIMask128<T> Op => default;

            public const string Name = "vtakeimask";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index) => ginx.vtakemask(x,index);            
        }

        public readonly struct TakeIMask256<T>  : IVUnaryScalar256Imm8<T,uint>
            where T : unmanaged
        {
            public static TakeIMask256<T> Op => default;

            public const string Name = "vtakeimask";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index) => ginx.vtakemask(x,index);
        }    
    }

}