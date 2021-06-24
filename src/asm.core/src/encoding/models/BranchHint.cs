//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmCodes;

    public readonly struct BranchHint
    {
        public BranchHintCode Code {get;}

        [MethodImpl(Inline)]
        public BranchHint(BranchHintCode src)
        {
            Code = src;
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)Code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code != 0;
        }

        public override string ToString()
            => Format();

        public string Format()
            => Encoded.FormatHex();

        [MethodImpl(Inline)]
        public static implicit operator BranchHint(BranchHintCode src)
            => new BranchHint(src);
    }
}