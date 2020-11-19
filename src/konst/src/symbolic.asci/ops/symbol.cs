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
        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciCharCode src)
            => src;

        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciLetterLo src)
            => (AsciCharCode)src;

        [MethodImpl(Inline)]
        public static AsciSymbol symbol(AsciLetterUp src)
            => (AsciCharCode)src;
   }
}