//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;

    public enum ImageConstantField : ushort
    {
        Sequence = 0,

        ParentId = 1,

        Source = 2,

        DataType = 3,

        Value = 4,
    }

    [Table]
    public struct ImageConstantRecord
    {
        public Count32 Sequence;

        public ArtifactIdentifier ParentId;

        public string Source;

        public ConstantTypeCode DataType;

        public BinaryCode Content;

        [MethodImpl(Inline)]
        public ImageConstantRecord(Count32 seq, HandleInfo parent, ConstantTypeCode tc, BinaryCode value)
        {
            Sequence = seq;
            ParentId = parent.Token;
            Source = parent.Source.ToString();
            DataType = tc;
            Content = value;
        }
    }
}