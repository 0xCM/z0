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
    using static Root;

    partial struct asci
    {        
        /// <summary>
        /// Transforms an uppercase character [A..Z] to the corresponding lowercase charcter [a..z];
        /// if the source character is not in the letter domain, the input is returned unharmed
        /// </summary>
        /// <param name="src">The source character</param>
        [MethodImpl(Inline), Op]
        public static char lowercase(char src)
             => AsciTest.letter(UpperCase, src)  ? lowercase((AsciLetterUpCode)src)  : src;

        [MethodImpl(Inline), Op]
        public static char lowercase(AsciLetterUpCode src)
            => skip(LettersLo,(int)src - (int)AsciLetterUpCode.First);
    }
}