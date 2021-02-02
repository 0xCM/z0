//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using T = AsmOpCodes;

    public readonly struct OpCodeEncoding
    {
        readonly uint Data;

        [MethodImpl(Inline)]
        public OpCodeEncoding(uint data)
            => Data = data;

        public byte Byte0
        {
            [MethodImpl(Inline)]
            get => T.part(this, n0);
        }

        public byte Byte1
        {
            [MethodImpl(Inline)]
            get => T.part(this, n1);
        }

        public byte Byte2
        {
            [MethodImpl(Inline)]
            get => T.part(this, n2);
        }

        public byte Modifier
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 24);
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes2(Data),0, 3);
        }

        public bit IsEscaped
        {
            [MethodImpl(Inline)]
            get => T.escaped(this);
        }

        public bit IsRepeat
        {
            [MethodImpl(Inline)]
            get => T.rep(this);
        }

        public bit SizeOverride
        {
            [MethodImpl(Inline)]
            get => T.sizeov(this);
        }

        public bit HasRex
        {
            [MethodImpl(Inline)]
            get => T.rex(this);
        }
    }
}