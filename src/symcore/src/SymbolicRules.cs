//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct SymbolicRules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static IsInRange range(char min, char max)
            => new IsInRange(SymbolRange.define(min,max));

        [MethodImpl(Inline), Op]
        public static IsOneOf oneof(params char[] src)
            => new IsOneOf(src);
    }
}