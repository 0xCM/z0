//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Types
    {
        // AsmString := '<mnemonic> {L|R}
        public struct AsmString
        {
            CharBlock80 Data;

            [MethodImpl(Inline)]
            public AsmString(string src)
            {
                Data = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator AsmString(string src)
                => new AsmString(src);
        }
    }
}