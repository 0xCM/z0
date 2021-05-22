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

    using C = AsciCharCode;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bit contains(SymbolRange<char> range, char src)
            => src >= range.Min && src <= range.Max;

        /// <summary>
        /// Determines whether the test code is a term of a specified sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="match">The test value</param>
        [MethodImpl(Inline), Op]
        public static bit contains(ReadOnlySpan<C> src, C match)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(match == skip(src,i))
                    return 1;
            return 0;
        }

        /// <summary>
        /// Determines whether the test code is within a specified range
        /// </summary>
        /// <param name="min">The inclusive minimum code value</param>
        /// <param name="max">The inclusive maximum code value</param>
        /// <param name="match">The test value</param>
        [MethodImpl(Inline), Op]
        public static bit contains(C min, C max, C match)
            => match >= min && match <= max;

        /// <summary>
        /// Tests whether a string contains a specified character
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="match">The character to match</param>
        [Op]
        public static bit contains(string src, char match)
        {
            if(text.nonempty(src))
                return(contains(span(src), match));
            else
                return false;
        }

        /// <summary>
        /// Tests whether a character span contains a specified character
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="match">The character to match</param>
        [MethodImpl(Inline), Op]
        public static bit contains(ReadOnlySpan<char> src, char match)
        {
            var len = src.Length;
            for(var i=0; i<len; i++)
                if(skip(src,i) == match)
                    return true;
            return false;
        }

        /// <summary>
        /// Tests whether a string contains a specified substring
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="match">The string to match</param>
        [Op]
        public static bit contains(string src, string match)
            => src.Contains(match);
    }
}