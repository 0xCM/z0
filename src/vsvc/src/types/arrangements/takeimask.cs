//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        public readonly struct TakeIMask128<T> : ISVImm8UnaryScalar128<T,ushort>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x, byte index) 
                => gvec.vtakemask(x,index);            
        }

        public readonly struct TakeIMask256<T>  : ISVImm8UnaryScalar256<T,uint>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,byte index) 
                => gvec.vtakemask(x,index);
        }    
    }
}