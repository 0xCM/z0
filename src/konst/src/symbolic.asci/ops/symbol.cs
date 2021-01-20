//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static AsciSymbol symbol(AsciCharCode src)
            => src;

        [MethodImpl(Inline), Op]
        public static AsciSymbol symbol(AsciLetterLo src)
            => (AsciCharCode)src;

        [MethodImpl(Inline), Op]
        public static AsciSymbol symbol(AsciLetterUp src)
            => (AsciCharCode)src;

        [MethodImpl(Inline), Op]
        public static ref readonly AsciSymbol symbol(in byte src)
            => ref memory.view<byte,AsciSymbol>(src);
   }
}