//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Tests whether the source string is either empty, null or consists only of whitespace
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool blank(string src)
            => sys.blank(src);

        [MethodImpl(Inline), Op]
        public static bool blank2(string src)
        {
            if(src != null)
            {
                var chars = span(src);
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var c = ref skip(chars,i);
                    if(!text.whitespace(c))
                        return false;
                }               
            }
            return true;
        }
    }
}