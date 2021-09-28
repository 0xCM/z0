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
        /// Specifies that a numeric value is within a closed interval
        /// </summary>
        public readonly struct Bounded<T>
            where T : unmanaged
        {
            /// <summary>
            /// The minimum value
            /// </summary>
            public readonly T Min;

            /// <summary>
            /// The maximum value
            /// </summary>
            public readonly T Max;

            [MethodImpl(Inline)]
            public Bounded(T min, T max)
            {
                Min = min;
                Max = max;
            }

            [MethodImpl(Inline)]
            public static implicit operator Bounded<T>((T min, T max) src)
                => new Bounded<T>(src.min, src.max);
        }
    }
}