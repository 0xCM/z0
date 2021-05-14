//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiComplete]
    public ref struct SpanWriter
    {
        readonly Span<byte> Data;

        uint Position;

        public Span<byte> Target
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint BytesWritten
        {
            [MethodImpl(Inline)]
            get => Position;
        }

        [MethodImpl(Inline)]
        public SpanWriter(Span<byte> src)
        {
            Data = src;
            Position = 0;
        }

        [MethodImpl(Inline)]
        public void Write8(byte src)
            => seek(Data, Position++) = src;

        [MethodImpl(Inline)]
        public void Write16(ushort src)
            => cell16(Data, Position += 2) = src;

        [MethodImpl(Inline)]
        public void Write32(uint src)
            => cell32(Data, Position += 4) = src;

        [MethodImpl(Inline)]
        public void Write64(ulong src)
            => cell64(Data, Position += 8) = src;

        [MethodImpl(Inline)]
        public void Write<T>(in T src)
            where T : unmanaged
        {
            cell<T>(Data, Position += size<T>()) = src;
        }
    }
}