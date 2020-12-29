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
        public static Name name<T>()
            => name(typeof(T));

        [MethodImpl(Inline), Op]
        public static Name name(string src)
            => new Name(src);
        [Op]
        public static Name name(Type spec)
        {
            var tag = spec.Tag<CmdAttribute>();
            if(tag)
            {
                var name = tag.Value.Name;
                if(text.empty(name))
                    return spec.Name;
                else
                    return name;
            }
            else
                return spec.Name;
        }
    }
}