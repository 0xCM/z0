//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmState
    {
        [MethodImpl(Inline)]
        public static AsmState create()
            => new AsmState(0);
        
        [MethodImpl(Inline)]
        AsmState(int i)
        {
            HexConfig = HexFormat.configure(zpad:false, specifier:false);
        }
        
        public readonly HexFormatConfig HexConfig;
    }
}