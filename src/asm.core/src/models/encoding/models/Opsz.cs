//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmPrefixCodes;

    /// <summary>
    /// Operand size override
    /// </summary>
    public readonly struct Opsz : IAsmPrefix<Opsz>
    {
        public SizeOverrideCode Code {get;}

        [MethodImpl(Inline)]
        public Opsz(SizeOverrideCode code)
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
        public static implicit operator SizeOverrides(Opsz src)
            =>new SizeOverrides(src.Code !=0, false);

        public static Opsz Empty => default;
    }
}