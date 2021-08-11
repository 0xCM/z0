//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, ReadOnlySpan<char> match, bool cased = true)
            => src.IndexOf(match, cased ? Cased : NoCase);

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, char match)
            => src.IndexOf(match);

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<C> src, C match)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(skip(src,i) == match)
                    return i;
            return NotFound;
        }

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<AsciSymbol> src, C match)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(skip(src,i) == match)
                    return i;
            return NotFound;
        }

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<AsciSymbol> src, char match)
            => index(src,(C)match);
    }
}