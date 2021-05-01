//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), Parse]
        public readonly struct Parse<T> : ITextParserFunc<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(string a)
            {
                if(Numeric.parser<T>().Parse(a, out var dst))
                    return dst;
                else
                    return default;
            }
        }
    }
}