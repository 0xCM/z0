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

    using C = AsciCharCode;

    partial class XText
    {
        [MethodImpl(Inline), Op]
        public static bool IsWhitespace(this char src)
        {
            var data = AsciWhitespaceCodes.Data;
            var count = data.Length;
            var match = (C)src;
            for(var i=0; i<count; i++)
            {
                if((skip(data,i) == match))
                    return true;
            }
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bool IsSpace(this char c)
            => (C)c == C.Space;

        [MethodImpl(Inline), Op]
        public static bool IsWhitespace(this string src)
        {
            var count = src.Length;
            if(count == 0)
                return false;

            var chars = span(src);
            for(var i=0; i<count; i++)
            {
                if(!skip(chars,i).IsWhitespace())
                    return false;
            }
            return true;
        }
    }
}