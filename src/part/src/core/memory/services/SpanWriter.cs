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

    public ref struct SpanWriter
    {
        readonly Span<byte> Data;

        uint Position;

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

        public Span<byte> Target
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public void Write8(byte src)
        {
            seek(Data, Position++) = src;
        }

        [MethodImpl(Inline)]
        public void Write16(ushort src)
        {
            cell16(Data, Position) = src;
            Position+=2;
        }

        [MethodImpl(Inline)]
        public void Write32(uint src)
        {
            cell32(Data, Position) = src;
            Position+=4;
        }

        [MethodImpl(Inline)]
        public void Write64(ulong src)
        {
            cell64(Data, Position) = src;
            Position+=8;
        }

        [MethodImpl(Inline)]
        public void Write<T>(in T src)
            where T : unmanaged
        {
            cell<T>(Data, Position) = src;
            Position += size<T>();
        }
    }
}