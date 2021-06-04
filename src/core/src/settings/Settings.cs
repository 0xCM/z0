//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Settings
    {
        const NumericKind Closure = UnsignedInts;

        public static Outcome parse(string src, out Setting<string> dst)
        {
            if(sys.empty(src))
            {
                dst = default;
                return (false, "!!Empty!!");
            }
            else
            {
                var i = src.IndexOf(Chars.Colon);
                if(i == NotFound)
                {
                    dst = default;
                    return (false, "Setting delimiter not found");
                }
                else
                {
                    if(i == 0)
                        dst = new Setting<string>(EmptyString, TextTools.slice(src,i+1));
                    else
                        dst = new Setting<string>(TextTools.slice(src,0, i), TextTools.slice(src,i+1));
                    return true;
                }
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> empty<T>()
            => Setting<T>.Empty;
    }
}