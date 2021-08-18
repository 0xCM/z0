//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RegWidth
    {
        public RegWidthCode Code {get;}

        [MethodImpl(Inline)]
        public RegWidth(RegWidthCode code)
        {
            Code = code;
        }

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(RegWidthCode src)
            => new RegWidth(src);

        [MethodImpl(Inline)]
        public static implicit operator RegWidthCode(RegWidth src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator byte(RegWidth src)
            => (byte)src.Code;
    }
}