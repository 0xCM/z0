//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [Record(TableId)]
    public struct XedCase : IRecord<XedCase>
    {
        public const string TableId = "xed.case";

        public Identifier CaseId;

        public FS.FilePath ScriptPath;

        public FS.FilePath SrcPath;

        public FS.FilePath SummaryPath;

        public FS.FilePath DetailPath;
    }
}