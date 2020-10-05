//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ImageData : ITableSpan<ImageData,byte>
    {
        public readonly ImageToken Source;

        readonly byte[] Data;

        [MethodImpl(Inline)]
        public ImageData(ImageToken src, byte[] content)
        {
            Source = src;
            Data = content;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint ImageSize
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public ImageData Refresh(byte[] data)
            => new ImageData(Source, data);

        [MethodImpl(Inline)]
        public static implicit operator ImageData((ImageToken src, byte[] data) x)
            => new ImageData(x.src, x.data);

        [MethodImpl(Inline)]
        public static implicit operator ImageData((ImageToken src, BinaryCode data) x)
            => new ImageData(x.src, x.data);

        [MethodImpl(Inline)]
        public static implicit operator ImageData(Paired<ImageToken,BinaryCode> x)
            => new ImageData(x.Left, x.Right);
    }
}