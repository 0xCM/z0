//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    /// <summary>
    /// Address size override
    /// </summary>
    public readonly struct Adsz : IAsmPrefix<SizeOverrideCode>
    {
        public SizeOverrideCode Code {get;}

        [MethodImpl(Inline)]
        public Adsz(SizeOverrideCode code)
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
        public static implicit operator SizeOverrides(Adsz src)
            => new SizeOverrides(false, src.Code !=0);

        public static Adsz Empty => default;
    }
}