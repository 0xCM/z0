//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public readonly struct Range<T> : ITerm<T>
            where T : unmanaged, IEquatable<T>, IComparable<T>
        {
            /// <summary>
            /// The min value in the range
            /// </summary>
            public readonly T Min;

            /// <summary>
            /// The max value in the range
            /// </summary>
            public readonly T Max;

            [MethodImpl(Inline)]
            public Range(T min, T max)
            {
                Min = min;
                Max = max;
            }

             public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Range<T>((T min, T max) src)
                => new Range<T>(src.min, src.max);
        }
    }
}