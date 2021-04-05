//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstring : IEquatable<AsmBitstring>
    {
        public AsmHexCode Code {get;}

        readonly MemoryAddress Bits;

        [MethodImpl(Inline)]
        public AsmBitstring(AsmHexCode code, string bits)
        {
            Code = code;
            Bits = memory.address(string.Intern(bits));
        }

        public override int GetHashCode()
            => (int)Bits.Hash;

        [MethodImpl(Inline)]

        public bool Equals(AsmBitstring src)
            => Bits.Equals(src.Bits);

        public override bool Equals(object src)
            => src is AsmBitstring b && Equals(b);

        public static implicit operator AsmBitstring((AsmHexCode code, string bits) src)
            => new AsmBitstring(src.code, src.bits);
    }
}