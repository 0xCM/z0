//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public readonly struct OperandSizeOverride : IAsmPrefix<OperandSizeOverride>
    {
        public SizeOverride Code {get;}

        [MethodImpl(Inline)]
        public OperandSizeOverride(SizeOverride code)
        {
            Code = code;
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

        [MethodImpl(Inline)]
        public static implicit operator SizeOverrides(OperandSizeOverride src)
            =>new SizeOverrides(src.Code !=0, false);

        public static OperandSizeOverride Empty => default;
    }
}