//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static AsciSymbol ToSymbol(this AsciCharCode src)
            => src;

        [MethodImpl(Inline)]
        public static AsciSymbol ToSymbol(this AsciLetterLo src)
            => (AsciCharCode)src;

        [MethodImpl(Inline)]
        public static AsciSymbol ToSymbol(this AsciLetterUp src)
            => (AsciCharCode)src;
    }
}
