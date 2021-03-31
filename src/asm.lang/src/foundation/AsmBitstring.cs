//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstring
    {
        readonly MemoryAddress Bits;

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmBitstring(AsmHexCode code, string bits)
        {
            Code = code;
            Bits = memory.address(string.Intern(bits));
        }
    }
}