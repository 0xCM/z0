//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    [Record(TableId)]
    public struct BuildLogEntry : IRecord<BuildLogEntry>
    {
        public const string TableId = "logs.build";

        public BuildEventKind EventKind;

        public EventLevel EventLevel;

        public Timestamp Timestamp;

        public TextBlock Message;

        public Name HelpKeyword;

        public Name SenderName;
    }

    public enum BuildEventKind : byte
    {
        None,

        ProjectStarted,

        ProjectFinished,

        BuildStarted,

        BuildFinished,

        BuildWarning,

        BuildError,

        BuildStatus,

        BuildMessage
    }
}