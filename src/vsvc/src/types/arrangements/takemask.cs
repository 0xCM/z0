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
        public readonly struct TakeMask128<T> : ISVUnaryScalar128<T,ushort>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public ushort Invoke(Vector128<T> x) 
                => gvec.vtakemask(x);            
        }

        public readonly struct TakeMask256<T> : ISVUnaryScalar256<T,uint>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x) 
                => gvec.vtakemask(x);
        }    
    }
}