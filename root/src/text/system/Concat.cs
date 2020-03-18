//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    partial class TextExtensions
    {
        /// <summary>
        /// Joins a sequence of source characters with optional interspersed separator
        /// </summary>
        /// <param name="chars">The characters to join</param>
        /// <param name="sep">The character to intersperse</param>
        public static string Concat(this IEnumerable<char> chars, char? sep = null)
        {
            if(sep == null)
                return new string(chars.ToSpan());
            else
                return new string(chars.Intersperse(sep.Value).ToSpan());                        
        }

    }
}