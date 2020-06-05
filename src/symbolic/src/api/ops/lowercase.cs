//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
    using static AsciDataStrings;
    using static Symbolics;

    partial class Symbolic
    {
        /// <summary>
        /// if given an uppercase character [A..Z], produces the corresponding lowercase charcter [a..z]
        /// Otherwise, returns the input unharmed
        /// </summary>
        /// <param name="src">The source character</param>
        [MethodImpl(Inline), Op]
        public static char lowercase(char src)
             => SymTest.IsLetter(UpperCase, src)  ? lowercase((AsciLetterUpCode)src)  : src;

        [MethodImpl(Inline), Op]
        public static char lowercase(AsciLetterUpCode src)
            => skip(LettersLo,(int)src - (int)AsciLetterUpCode.First);
    }
}