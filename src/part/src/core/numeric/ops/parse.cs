//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericParser<T> parser<T>()
            where T : unmanaged
                => default(NumericParser<T>);

        [MethodImpl(Inline), ParseFunction, NumericClosures(AllNumeric)]
        public static bool parse<T>(string src, out T dst)
            => NumericParser.parse(src, out dst);
    }
}