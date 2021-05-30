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
        readonly AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        internal AsmBitstring(AsmHexCode src)
        {
            Code = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsEmpty;
        }

        public string Format()
            => api.format(Code);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmBitstring(AsmHexCode src)
            => new AsmBitstring(src);
    }
}