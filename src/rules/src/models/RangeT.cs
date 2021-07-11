//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a stewise-contiguous sequence of scalar values, available on-demand, that satisfy upper/lower bound constraints
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        public readonly struct Range<T> : IRule<Range<T>,T>
        {
            /// <summary>
            /// The min value in the range
            /// </summary>
            public T Min {get;}

            /// <summary>
            /// The max value in the range
            /// </summary>
            public T Max {get;}

            /// <summary>
            /// The distance between successive range points
            /// </summary>
            public T Step {get;}

            [MethodImpl(Inline)]
            public Range(T min, T max, T step)
            {
                Min = min;
                Max = max;
                Step = step;
            }

            public string Format()
                => "{" + $"{Min}...{Max}" + "}" + "[" + $"{Step}" + "]";

            public override string ToString()
                => Format();
        }
    }
}