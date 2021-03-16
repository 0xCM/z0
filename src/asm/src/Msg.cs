//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    [ApiComplete]
    partial struct Msg
    {

        public static MsgPattern<FS.FolderPath> ObliteratingDirectory => "Obliterating the directory {0}";

        public static MsgPattern<FS.FolderPath> ObliteratedDirectory => "Consigned the directory {0} to oblivion";

        public static RenderPattern<Count> EmittingInstructionRecords => "Emitting {0} instruction tables";

        public static RenderPattern<Count,Count> EmittedInstructionRecords => "Emitted a total of {0} records for {1} instruction tables";

        public static MsgPattern<ApiHostUri,Count> RunningHostEmissionWorkflow => "Running {0} emission workflow for {1} members";

        public static MsgPattern<Count,ApiHostUri> ParsedExtractBlocks => "Parsed {0} {1} extract blocks";

        public static MsgPattern<ApiHostUri> EmittingHostRoutines => "Emitting {0} routines";

        public static MsgPattern<Count,ApiHostUri,FS.FileUri> EmittedHostRoutines => "Emitted {0} {1} routines to {2}";

        public static MsgPattern<Count> CreatingAsmRowsFromBlocks => "Creating AsmRows for {0} blocks";

        public static MsgPattern<Count> CreatedAsmRowsFromBlocks => "Created {0} AsmRows";

        public static MsgPattern<ApiHostUri> CreatingApiStatements => "Creating {0} host api statements";

        public static MsgPattern<ApiHostUri,Count> CreatedApiStatements => "Created {0} {1} host api statement";

        public static MsgPattern<Count,Count,FS.FileUri> ParsedStatements => "Parsed {0} full rows and {1} partial rows from {2}";
    }
}