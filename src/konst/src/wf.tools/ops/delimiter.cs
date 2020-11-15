//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        /// <summary>
        /// Creates a <see cref='OptionDelimiter'/>
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Factory]
        public static OptionDelimiter delimiter(char c0)
            => new OptionDelimiter((AsciCharCode)c0);

        /// <summary>
        /// Creates a <see cref='OptionDelimiter'/>
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Factory]
        public static OptionDelimiter delimiter(char c0, char c1)
            => new OptionDelimiter((AsciCharCode)c0, (AsciCharCode)c1);

        [MethodImpl(Inline), Factory]
        public static OptionDelimiter delimiter(string src)
        {
            var count = src.Length;
            if(count == 0 || count > 2)
                @throw(bad(src));
            if(count == 1)
                return delimiter(src[0]);
            else
                return delimiter(src[0], src[1]);
        }
    }
}