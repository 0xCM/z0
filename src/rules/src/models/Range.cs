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
        public readonly struct Range : IDataType<Range>
        {
            public long Min {get;}

            public long Max {get;}

            [MethodImpl(Inline)]
            public Range(long min, long max)
            {
                Min = min;
                Max = max;
            }

            public string Format()
                => string.Format("[{0},{1}]", Min, Max);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Range((long min, long max) src)
                => new Range(src.min, src.max);
        }
    }
}