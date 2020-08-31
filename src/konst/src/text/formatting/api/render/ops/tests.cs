//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
        
    partial struct Render
    {
        [MethodImpl(Inline), Op]
        public static bool binary(NumericFormatKind src)
            =>  (src & NumericFormatKind.Binary) != 0;

        [MethodImpl(Inline), Op]
        public static bool @decimal(NumericFormatKind src)
            =>  (src & NumericFormatKind.Decimal) != 0;

        [MethodImpl(Inline), Op]
        public static bool hex(NumericFormatKind src)
            =>  (src & NumericFormatKind.Hex) != 0;
            
        [MethodImpl(Inline), Op]
        public static bool blocked(NumericFormatKind src)
            =>  (src & NumericFormatKind.Blocked) != 0;

        [MethodImpl(Inline), Op]
        public static bool prefixed(NumericFormatKind src)
            =>  (src & NumericFormatKind.Prefixed) != 0;

        [MethodImpl(Inline), Op]
        public static bool suffixed(NumericFormatKind src)
            =>  (src & NumericFormatKind.Suffixed) != 0;

        [MethodImpl(Inline), Op]
        public static bool zPad(NumericFormatKind src)
            =>  (src & NumericFormatKind.ZeroPadded) != 0;
    }
}