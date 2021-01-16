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

    [Record(TableId)]
    public struct CliConstantInfo : IRecord<CliConstantInfo>
    {
        public const string TableId = "cli.constant";

        public Count Sequence;

        public ClrToken ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public CliConstantInfo(Count seq, CliTableIndex parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Key;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}