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
        public NativeWidthCode Code {get;}

        [MethodImpl(Inline)]
        public RegWidth(NativeWidthCode code)
        {
            Code = code;
        }

        public string Format()
            => AsmRender.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(NativeWidthCode src)
            => new RegWidth(src);

        [MethodImpl(Inline)]
        public static implicit operator NativeWidthCode(RegWidth src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator byte(RegWidth src)
            => (byte)src.Code;
    }
}