//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        [MethodImpl(Inline)]
        public static ref BitField256<F,T> write<F,T>(T src, ref BitField256<F,T> dst, F index)
            where T : unmanaged
            where F : unmanaged, Enum
        {
            var mask = Mask(dst,index);
            var conformed = gmath.and(src,mask);
            var i  = Enums.scalar<F,byte>(index);    
            dst.State = vcell(conformed, i, dst.State);
            return ref dst;
        }
    }
}