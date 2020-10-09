//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct ImageDataRecord
    {
        public const string TableId = "image.bytes";

        public const byte FieldCount = 2;

        public const byte RowDataSize = 32;

        public ImageToken Source;

        public BinaryCode Data;

        [MethodImpl(Inline)]
        public ImageDataRecord(ImageToken src, byte[] content)
        {
            Source = src;
            Data = content;
        }

        [MethodImpl(Inline)]
        public static implicit operator ImageDataRecord((ImageToken src, byte[] data) x)
            => new ImageDataRecord(x.src, x.data);

        [MethodImpl(Inline)]
        public static implicit operator ImageDataRecord((ImageToken src, BinaryCode data) x)
            => new ImageDataRecord(x.src, x.data);

        [MethodImpl(Inline)]
        public static implicit operator ImageDataRecord(Paired<ImageToken,BinaryCode> x)
            => new ImageDataRecord(x.Left, x.Right);
    }
}