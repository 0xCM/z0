//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Cmd
    {
        /// <summary>
        /// Creates a <see cref='ArgPrefix'/>
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Factory]
        public static ArgPrefix prefix(char c0)
            => new ArgPrefix((AsciCharCode)c0);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/>
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Factory]
        public static ArgPrefix prefix(char c0, char c1)
            => new ArgPrefix((AsciCharCode)c0, (AsciCharCode)c1);

        [MethodImpl(Inline)]
        public static ArgPrefix prefix(string src)
        {
            var count = text.length(src);
            if(count == 0)
                return ArgPrefix.Empty;
            else if(count == 1)
                return new ArgPrefix((AsciCharCode)src[0]);
            else
                return new ArgPrefix((AsciCharCode)src[0], (AsciCharCode)src[1]);
        }
    }
}