//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;

    using static Konst;

    public enum ImageConstantField : ushort
    {
        Sequence = 0,

        ParentId = 1,

        Source = 2,

        DataType = 3,

        Value = 4,
    }

    public enum ImageConstantFieldWidth : ushort
    {
        Sequence = 12,

        ParentId = 20,

        Source = 20,

        DataType = 20,

        Value = 30,
    }

    [StructLayout(LayoutKind.Sequential), Table(TableName)]
    public struct ImageConstantRecord
    {
        public const string TableName = "image.constant";
        public Count Sequence;

        public ClrArtifactKey ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public ImageConstantRecord(Count seq, HandleToken parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Token;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}