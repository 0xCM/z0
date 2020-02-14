//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

   public readonly struct FixedSeg<F,T> : IFixed
        where F : unmanaged, IFixed
        where T : struct        
    {
        
        [MethodImpl(Inline)]
        public FixedSeg(F value)
        {
            this.FixedValue = value;
            this.FixedWidth = (FixedWidth)bitsize<T>();   
        }

        public readonly F FixedValue;

        public FixedWidth FixedWidth {get;}
    }
}