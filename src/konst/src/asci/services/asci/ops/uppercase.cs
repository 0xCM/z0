//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static AsciDataStrings;
    using static z;

    partial struct asci
    {        
        /// <summary>
        /// if given a lowercase character [a..z], produces the corresponding uppercase charcter [A..z]
        /// Otherwise, returns the input unharmed
        /// </summary>
        /// <param name="src">The source character</param>
        [MethodImpl(Inline), Op]
        public static char uppercase(char src)
             => AsciTest.letter(LowerCase, src)  ? uppercase((AsciLetterLoCode)src) : src;

        [MethodImpl(Inline), Op]
        public static char uppercase(AsciLetterLoCode src)
            => skip(LettersUp,(uint)src - (uint)AsciLetterLoCode.First);
    }
}