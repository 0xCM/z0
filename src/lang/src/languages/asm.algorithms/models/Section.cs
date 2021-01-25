//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmAlgorithms
    {
        /// <summary>
        /// Represents a closed interval of bits from an operand and corresponds to the notation [max:min]
        /// </summary>
        public readonly struct Section<T>
        {
            public T Min {get;}

            public T Max {get;}

            [MethodImpl(Inline)]
            public Section(T min, T max)
            {
                Min = min;
                Max = max;
            }

            [MethodImpl(Inline)]
            public static implicit operator Section<T>((T min, T max) src)
                => new Section<T>(src.min, src.max);
        }
    }
}