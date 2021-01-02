//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct SummaryComment : IRecord<SummaryComment>
    {
        public const string TableId = "doc.comments.summary";

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