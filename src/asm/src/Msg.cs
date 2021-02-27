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
        public static RenderPattern<Count> EmittingInstructionRecords => "Emitting {0} instruction tables";

        public static RenderPattern<Count,Count> EmittedInstructionRecords => "Emitted a total of {0} records for {1} instruction tables";

        public static MsgPattern<ApiHostUri,Count> RunningHostEmissionWorkflow => "Running {0} emission workflow for {1} members";

        public static MsgPattern<Count,ApiHostUri> ParsedExtractBlocks => "Parsed {0} {1} extract blocks";

        public static MsgPattern<ApiHostUri> EmittingHostRoutines => "Emitting {0} routines";

        public static MsgPattern<Count,ApiHostUri,FS.FileUri> EmittedHostRoutines => "Emitted {0} {1} routines to {2}";
    }
}