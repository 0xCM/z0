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
        public NativeSize Size {get;}

        [MethodImpl(Inline)]
        public RegWidth(NativeSizeCode code)
        {
            Size = code;
        }

        public string Format()
            => AsmRender.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(NativeSizeCode src)
            => new RegWidth(src);

        [MethodImpl(Inline)]
        public static implicit operator NativeSizeCode(RegWidth src)
            => src.Size;
    }
}