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
        /// Creates a <see cref='CmdArgPrefix'/>
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(char c0)
            => new CmdArgPrefix((AsciCharCode)c0);

        /// <summary>
        /// Creates a <see cref='CmdArgPrefix'/>
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(char c0, char c1)
            => new CmdArgPrefix((AsciCharCode)c0, (AsciCharCode)c1);

        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(string src)
        {
            var count = src.Length;
            if(count == 0 || count > 2)
                @throw(badarg(src));
            if(count == 1)
                return prefix(src[0]);
            else
                return prefix(src[0], src[1]);
        }
    }
}