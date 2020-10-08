//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static RP;

    public enum PartStringKind
    {
        System = 0,

        User = 1,
    }

    public readonly struct ImageStringRecords
    {
        public const string DataType = "strings";

        public const string UserKind = "user";

        public const string SystemKind = "system";

        public const string UserTargetFolder = DataType + ExtSep + UserKind;

        public const string SystemTargetFolder = DataType + ExtSep + SystemKind;

        public const string DataTypeExt = DataType + ExtSep + DataExt;

        public const string UserKindExt = UserKind + ExtSep + DataTypeExt;

        public const string SystemKindExt = SystemKind + ExtSep + DataTypeExt;
    }

    public enum ImageStringSource : byte
    {
        System = 1,

        User = 2,
    }

    public enum ImageStringField : ushort
    {
        Sequence,

        Source,

        HeapSize,

        Length,

        Offset,

        Value,
    }

    public enum ImageStringFieldWidth : ushort
    {
        Sequence = 12,

        Source = 12,

        HeapSize = 12,

        Length = 12,

        Offset = 12,

        Value = 12,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UserStringRecord
    {
        public const string TableId = "image.strings.user";

        public const string DataType = "string";

        public Count Sequence;

        public ImageStringSource Source;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Content;

        [MethodImpl(Inline)]
        public UserStringRecord(Count seq, ImageStringSource src, ByteSize heap, Address32 offset, string data)
        {
            Sequence = seq;
            Source = src;
            HeapSize = heap;
            Length = data.Length;
            Offset = offset;
            Content = data;
        }
    }
}