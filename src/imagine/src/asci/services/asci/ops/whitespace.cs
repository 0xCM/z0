//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    partial struct asci
    {        
        /// <summary>
        /// Tests whether a character is deignated as whitespace
        /// </summary>
        /// <param name="c"></param>
        [MethodImpl(Inline), Op]
        public static bool whitespace(char c)
            => AsciTest.whitespace(c);

        [MethodImpl(Inline), Op]
        public static bool empty(string s)
        {
            if(s == null)
                return true;
            
            var data = z.span(s);
            for(var i=0u; i<data.Length; i++)
            {
                ref readonly var c = ref z.skip(data,i);
                if(!whitespace(c))
                    return false;
            }
            return true;
        }
    }
}