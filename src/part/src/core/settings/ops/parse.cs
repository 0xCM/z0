//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    partial struct Settings
    {
        [Op, Closures(Closure)]
        public static Outcome parse<T>(string src, out Setting<T> dst, char delimiter = Chars.Colon)
        {
            dst = empty<T>();
            if(text.nonempty(src))
            {
                var name = EmptyString;
                var input = src;
                if(TextQuery.contains(src, delimiter))
                {
                    name = src.LeftOfFirst(delimiter);
                    input = src.RightOfFirst(delimiter);
                }

                if(typeof(T) == typeof(string))
                {
                    dst = define(name, generic<T>(input));
                    return true;
                }
                else if (typeof(T) == typeof(bool))
                {
                    if(DataParser.parse(input, out bool value))
                    {
                        dst = define(name, generic<T>(value));
                        return true;
                    }
                }
                else if(typeof(T) == typeof(bit))
                {
                    if(DataParser.parse(input, out bit u1))
                    {
                        dst = define(name, generic<T>(u1));
                        return true;
                    }
                }
                else if(DataParser.numeric(input, out T g))
                {
                    dst = define(name, g);
                    return true;
                }
                else if(typeof(T).IsEnum)
                {
                    if(Enums.parse(typeof(T), src, out object o))
                    {
                        dst = define(name, (T)o);
                        return true;
                    }
                }
                else if(src.Length == 1 && typeof(T) == typeof(char))
                {
                    dst = define(name, generic<T>(name[0]));
                    return true;
                }
            }
            return false;
        }
    }
}