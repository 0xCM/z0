//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = AsmBitstrings;

    public readonly struct AsmBitstring
    {
        readonly StringAddress Address {get;}

        [MethodImpl(Inline)]
        internal AsmBitstring(StringAddress src)
        {
            Address = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Address.IsNonZero;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Address.Hash;
        }

        public string Format()
            => Address.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmBitstring(AsmHexCode src)
            => new AsmBitstring(api.format(src));
    }
}