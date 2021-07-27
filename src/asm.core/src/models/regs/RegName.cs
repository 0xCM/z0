//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RegName
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        internal RegName(ulong data)
        {
            Data = data;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        public string Format()
            => AsmRegNames.format(this);

        public override string ToString()
            => Format();

        public static RegName Empty
        {
            [MethodImpl(Inline)]
            get => new RegName(0);
        }
    }
}