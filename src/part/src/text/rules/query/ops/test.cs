//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;
    using static core;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bool test(char src, OneOf<char> match)
            => contains(match.Elements, src);

        [Op]
        public static bool test(string src, OneOf<string> match, out int index)
        {
            var count = match.Count;
            var elements = match.Elements.View;
            for(var i=0; i<count; i++)
            {
                if(string.Equals(skip(elements,i), src))
                {
                    index = i;
                    return true;
                }
            }
            index = NotFound;
            return false;
        }
    }
}