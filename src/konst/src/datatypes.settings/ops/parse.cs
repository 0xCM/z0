//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial struct Settings
    {
        [Op, Closures(Closure)]
        public static bool parse<T>(string src, out Setting<T> dst)
        {
            dst = empty<T>();
            if(text.nonempty(src))
            {
                var name = EmptyString;
                var input = src;
                if(Query.contains(src,Chars.Colon))
                {
                    name = src.LeftOfFirst(Chars.Colon);
                    input = src.RightOfFirst(Chars.Colon);
                }

                if(typeof(T) == typeof(string))
                {
                    dst = define(name, root.generic<T>(input));
                    return true;
                }
                else if(typeof(T) == typeof(bool))
                {
                    if(bool.TryParse(input, out var value))
                    {
                        dst = define(name, memory.generic<T>(value));
                        return true;
                    }
                }
            }
            return false;
        }
    }
}