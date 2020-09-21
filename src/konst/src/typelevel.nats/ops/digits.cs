//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial class TypeNats
    {        
        /// <summary>
        /// Creates a squence of prmitive values from a natural value
        /// </summary>
        /// <param name="src">The source value</param>
        public static byte[] digits(ulong src)
        {
            var text = src.ToString();
            var chars = new byte[text.Length];
            for(var i=0; i<text.Length; i++)
                chars[i] = byte.Parse(text[i].ToString());                
            return chars;
        }
    }
}