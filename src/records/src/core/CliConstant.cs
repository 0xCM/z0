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
    public struct CliConstant
    {
        public const string TableId = "cli.constant";

        public const byte FieldCount = 5;

        public enum Fields : ushort
        {
            Sequence = 0,

            ParentId = 1,

            Source = 2,

            DataType = 3,

            Value = 4,
        }

        public Count Sequence;

        public ClrArtifactKey ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public CliConstant(Count seq, CliHandleToken parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Token;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}