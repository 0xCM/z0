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

    [StructLayout(LayoutKind.Sequential), Table(TableId)]
    public struct CliConstant : IRecord<CliConstant>
    {
        public const string TableId = "cli.constant";

        public enum Fields : ushort
        {
            Sequence = 0,

            ParentId = 1,

            Source = 2,

            DataType = 3,

            Value = 4,
        }

        public Count Sequence;

        public CliArtifactKey ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public CliConstant(Count seq, CliTableIndex parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Key;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}