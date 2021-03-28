//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;
    using static Part;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string intersperse(string src, char delimiter)
            => Transform.intersperse(src, delimiter);

        [MethodImpl(Inline)]
        public static string intersperse(string src, string delimiter)
            => Transform.intersperse(src, delimiter);

        [Op]
        public static string intersperse(string src, char c, uint frequency)
        {
            var count = src.Length;
            var j=0;
            var buffer = text.buffer();
            for(var i=0; i<count; i++)
            {
                buffer.Append(src[i]);
                if(i != 0 && ((i - 1) % frequency ==0))
                    buffer.Append(c);
            }
            return buffer.Emit();
        }
    }
}