//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static SFxShape;

    partial class VServices
    {
        public readonly struct TakeIMask128<T> : IUnaryScalarImm8Op128<T,ushort>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index)
                => gvec.vtakemask(x,index);
        }

        public readonly struct TakeIMask256<T>  : IUnaryScalarImm8Op256<T,uint>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index)
                => gvec.vtakemask(x,index);
        }
    }
}