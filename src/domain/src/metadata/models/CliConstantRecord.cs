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


    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct CliConstantRecord
    {
        public const string TableId = "image.constant";

        public const byte FieldCount = 5;

        public enum Fields : ushort
        {
            Sequence = 0,

            ParentId = 1,

            Source = 2,

            DataType = 3,

            Value = 4,
        }

        public enum RenderWidths : ushort
        {
            Sequence = 12,

            ParentId = 20,

            Source = 20,

            DataType = 20,

            Value = 30,
        }

        public Count Sequence;

        public ClrArtifactKey ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public CliConstantRecord(Count seq, CliHandleToken parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Token;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}