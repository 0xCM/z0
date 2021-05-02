//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    [Record(TableId)]
    public struct XedCase : IRecord<XedCase>
    {
        public const string TableId = "xed.case";

        public Identifier CaseId;

        public FS.FilePath InputPath;

        public FS.FilePath SummaryPath;

        public FS.FilePath DetailPath;
    }
}