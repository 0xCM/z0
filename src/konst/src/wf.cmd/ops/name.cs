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
        public static CmdName name<T>()
            => name(typeof(T));

        [MethodImpl(Inline), Op]
        public static CmdName name(string src)
            => new CmdName(src);
        [Op]
        public static CmdName name(Type spec)
        {
            var tag = spec.Tag<CmdAttribute>();
            if(tag)
            {
                var name = tag.Value.Name;
                if(text.empty(name))
                    return new CmdName(spec.Name);
                else
                    return new CmdName(name);
            }
            else
                return new CmdName(spec.Name);
        }
    }
}