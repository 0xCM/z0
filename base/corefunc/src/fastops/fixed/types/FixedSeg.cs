//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

   
   public readonly struct FixedSeg<F,T> : IFixedSeg<F,T>
        where F : unmanaged, IFixed
        where T : struct        
    {
        
        [MethodImpl(Inline)]
        internal FixedSeg(F value)
        {
            this.FixedValue = value;
        }

        public readonly F FixedValue;
    }

}