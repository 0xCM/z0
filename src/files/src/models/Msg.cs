//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FS
    {
        public struct Msg
        {
            public static MsgPattern<FS.FileUri> ParsingFile => "Parsing {0}";

            public static MsgPattern<FS.FileUri> ParsedFile => "Parsed {0}";

            public static MsgPattern<FS.FileUri> DoesNotExist => "The file {0} has gone missing";
        }
    }
}