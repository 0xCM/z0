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

    partial struct asci
    {
        static AsciDataStrings AsciStrings => default;

        public static ReadOnlySpan<AsciCharCode> CharCodes
        {
            [MethodImpl(Inline)]
            get => Control.cast<AsciCharCode>(AsciStrings.CharBytes);
        }
    }
}