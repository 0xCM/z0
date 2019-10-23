//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a contiguous sequence of scalar values
    /// </summary>
    /// <typeparam name="T">The scalar type</typeparam>
    public readonly struct RangeExpr<T> : ILazySeqExpr<T>
        where T : unmanaged
    {
        public RangeExpr(T min, T max, T? step = null)
        {
            this.Min = min;
            this.Max = max;
            this.Step = step;
        }
        
        public readonly T Min;

        public readonly T Max;

        public readonly T? Step;

        public IEnumerable<T> Terms
            => range(Min,Max,Step);

        public int? Length 
            => convert<T,int>(gmath.sub(Max,Min));

        public string Format()
            => embrace($"{Min}...{Max}") 
                + (Step != null ? bracket($"{Step}") : string.Empty);

        public override string ToString()
            => Format();
    }

}