//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RexField
    {
        readonly uint4 Lo;

        [MethodImpl(Inline)]
        public RexField(uint4 src)
            => Lo = src;

        public bit B
        {
            [MethodImpl(Inline)]
            get => (bit)Lo;
        }

        public bit X
        {
            [MethodImpl(Inline)]
            get => (bit)(Lo >> 1);
        }

        public bit R
        {
            [MethodImpl(Inline)]
            get => (bit)(Lo >> 2);
        }

        public bit W
        {
            [MethodImpl(Inline)]
            get => (bit)(Lo >> 3);
        }

        public byte Encoded => 0x40 | Lo;

        public string Format()
            => Encoded.FormatHex();

        public override string ToString()
            => Format();
    }
}