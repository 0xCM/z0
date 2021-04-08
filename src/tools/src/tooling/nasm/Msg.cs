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

   partial struct Msg
   {
       public static MsgPattern<Count> ParsingNasmListEntries => "Parsing list entries from {0} lines";

       public static MsgPattern<Count> ParsedNasmListEntries => "Parsing {0} list entries";

        public static MsgPattern<FS.FileUri> ReadingNasmListing => "Reading nasm listing from {0}";

        public static MsgPattern<Count,FS.FileUri> ReadNasmListing => "Read {0} nasm list lines from {1}";
   }
}