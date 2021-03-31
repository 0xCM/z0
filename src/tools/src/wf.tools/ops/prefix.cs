//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using ACC = AsciCharCode;

    partial struct ToolCmd
    {
        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from a specified character
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(char c0)
            => new ArgPrefix((ACC)c0);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from two specified characters
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(char c0, char c1)
            => new ArgPrefix((ACC)c0, (ACC)c1);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from the leading source element(s)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(string src)
            => prefix(memory.chars(src));

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from the leading source element(s)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            if(count == 0)
                return ArgPrefix.Empty;
            else if(count == 1)
                return new ArgPrefix((ACC)memory.skip(src, 0));
            else
                return new ArgPrefix((ACC)memory.skip(src, 0), (ACC)memory.skip(src, 1));
        }
    }
}