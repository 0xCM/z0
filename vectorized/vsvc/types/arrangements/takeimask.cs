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
        public readonly struct TakeIMask128<T> : ISVImm8UnaryScalar128Api<T,ushort>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public Vec128Kind<T> VKind => default;

            public static TakeIMask128<T> Op => default;

            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index) 
                => gvec.vtakemask(x,index);            
        }

        public readonly struct TakeIMask256<T>  : ISVImm8UnaryScalar256Api<T,uint>
            where T : unmanaged
        {
            public const string Name = "vtakeimask";

            public Vec256Kind<T> VKind => default;

            public static TakeIMask256<T> Op => default;
            
            public OpIdentity Id => Identify.SFunc(Name,VKind);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index) 
                => gvec.vtakemask(x,index);
        }    
    }
}