//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class SymbolicData
    {
        /// <summary>
        /// Defines a 16-character sequence with terms that correspond to the ASCI characters for hex digits {0..9,A..F}
        /// </summary>
        public static ReadOnlySpan<char> UpperHexChars
        {
            [MethodImpl(Inline)]
            get => UpperHexCharData;
        }

        /// <summary>
        /// Defines a 16-character sequence with terms that correspond to the ASCI characters for hex digits {0..9,a..f}
        /// </summary>
        public static ReadOnlySpan<char> LowerHexChars
        {
            [MethodImpl(Inline)]
            get => LowerHexChareData;
        }

        static char[] UpperHexCharData 
            => new char[16]{'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};

        static char[] LowerHexChareData 
            => new char[16]{'0','1','2','3','4','5','6','7','8','9','a','b','d','d','e','f'};
    }
}