//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public struct BranchHint : IAsmPrefix<BranchHintCode>
    {
        BranchHintCode _Code;

        [MethodImpl(Inline)]
        public BranchHint(BranchHintCode src)
        {
            _Code = src;
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)_Code;
        }

        [MethodImpl(Inline)]
        public BranchHintCode Code()
            => _Code;

        [MethodImpl(Inline)]
        public void Code(BranchHintCode src)
            => _Code = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => _Code == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => _Code != 0;
        }

        public override string ToString()
            => Format();

        public string Format()
            => Encoded.FormatHex();

        [MethodImpl(Inline)]
        public static implicit operator BranchHint(BranchHintCode src)
            => new BranchHint(src);

        [MethodImpl(Inline)]
        public static implicit operator BranchHintCode(BranchHint src)
            => src.Code();

        [MethodImpl(Inline)]
        public static implicit operator byte(BranchHint src)
            => (byte)src._Code;
    }
}