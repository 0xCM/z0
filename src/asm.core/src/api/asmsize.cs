//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static NativeWidthCode code(BitWidth src)
        {
            if(src != 80)
            {
                var i = Pow2.log(src >> 3);
                return (NativeWidthCode)i;
            }
            else
                return NativeWidthCode.W80;
        }

        [MethodImpl(Inline), Op]
        public static NativeSize asmsize(BitWidth src)
            => code(src);
    }
}