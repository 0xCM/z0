//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a stewise-contiguous sequence of scalar values, available on-demand,
    /// that satisfy upper/lower bound constraints
    /// </summary>
    /// <typeparam name="T">The scalar type</typeparam>
    public readonly struct RangeExpr<T> : ILazySeqExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The min value in the range
        /// </summary>
        public readonly T Min;

        /// <summary>
        /// The max value in the range
        /// </summary>
        public readonly T Max;

        /// <summary>
        /// The distance between successive range points
        /// </summary>
        public readonly T Step;

        [MethodImpl(Inline)]
        public RangeExpr(T min, T max, T step)
        {
            Min = min;
            Max = max;
            Step = step;
        }

        public IEnumerable<T> Terms
            => gmath.range(Min,Max,Step);

        public int? Length
            => convert<T,int>(gmath.sub(Max,Min));

        public string Format()
            => text.embrace($"{Min}...{Max}") + text.bracket($"{Step}") ;

        public override string ToString()
            => Format();
    }
}