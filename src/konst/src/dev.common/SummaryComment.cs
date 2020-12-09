//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum CommentTargetKind : byte
    {
        None = 0,

        Type = 1,

        Method = 2,

        Field = 3,

        Property = 4,
    }

    [Record(TableId)]
    public struct SummaryComment : IRecord<SummaryComment>
    {
        public const string TableId = "comments";

        public CommentTargetKind Kind;

        public string Identifer;

        public string Summary;

        public SummaryComment(CommentTargetKind kind, string identifier, string summary)
        {
            Kind = kind;
            Identifer = identifier;
            Summary = summary;
        }
    }
}