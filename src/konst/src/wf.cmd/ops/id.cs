//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        public static CmdId id<T>()
            => id(typeof(T));

        [Op]
        public static CmdId id(Type spec)
        {
            var tag = spec.Tag<CmdAttribute>();
            if(tag)
            {
                var name = tag.Value.Name;
                if(text.empty(name))
                    return new CmdId(spec.Name);
                else
                    return new CmdId(name);
            }
            else
                return new CmdId(spec.Name);
        }

        /// <summary>
        /// Parses a <see cref='CmdId'/> from a command identifier
        /// </summary>
        /// <param name="src">The command identifier</param>
        [MethodImpl(Inline), Op]
        public static CmdId id(string src)
            => new CmdId(src);
    }
}