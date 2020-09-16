//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum DocTargetKind
    {
        None = 0,

        Type = 1,

        Method = 2,

        Field = 3,

        Property = 4,
    }

    public readonly struct SummaryComment
    {
        public readonly DocTargetKind Kind;

        public readonly string Identifer;

        public readonly string Summary;

        public SummaryComment(DocTargetKind kind, string identifier, string summary)
        {
            Kind = kind;
            Identifer = identifier;
            Summary = summary;
        }
    }
}