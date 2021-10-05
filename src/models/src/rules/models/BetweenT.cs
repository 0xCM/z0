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
        public readonly struct Between<T> : ITerm
            where T : unmanaged, IEquatable<T>, IComparable<T>
        {
            public readonly T Min;

            public readonly T Max;

            public Between(T min, T max)
            {
                Min = min;
                Max = max;
            }

             public string Format()
                => api.format(this);

             public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Between<T>((T min, T max) src)
                => new Between<T>(src.min, src.max);
        }
    }
}