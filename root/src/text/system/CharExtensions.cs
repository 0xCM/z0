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
    
    public static partial class CharExtensions
    {
        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Replicate(this char src, int count)
            => text.replicate(src,count);

        /// <summary>
        /// Determines whether the source character is a decimal digit per the unicode standard
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static bool IsDecimalDigit(this char c)
            => char.IsDigit(c);

        /// <summary>
        /// Determines whether the source character is a binary digit, i.e. either '0' or '1'
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static bool IsBinaryDigit(this char c)
            => c == '0' || c == '1';

        public static char ToDecimalChar(this byte src)
        {
            if(src == 0)
                return '0';
            else if(src == 1)
                return '1';
            else if(src == 2)
                return '2';
            else if(src == 3)
                return '3';
            else if(src == 4)
                return '4';
            else if(src == 5)
                return '5';
            else if(src == 6)
                return '6';
            else if(src == 7)
                return '7';
            else if(src == 8)
                return '8';
            else if(src == 9)
                return '9';
            else
                return '∅';                        
        }            


    }
}