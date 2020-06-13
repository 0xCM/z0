//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Konst;
    using static Control;

    partial class AsciCodes
    {
        static AsciDataStrings AsciStrings => default;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in asci16 src)
            => cast<AsciCharCode>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(ASCI asci)
            => cast<AsciCharCode>(AsciStrings.CharBytes);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => AsciStrings.codes(offset, count);
    }
}