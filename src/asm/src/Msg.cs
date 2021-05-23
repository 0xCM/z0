//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Asm;

    using static Rules;

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

        public static MsgPattern<Count> DecodingParts => "Decoding {0} parts";

        public static MsgPattern<Count,PartName> DecodingPartRoutines => "Decoding {0} {1} hosts";

        public static MsgPattern<Count,PartName,ApiDecoderStats> DecodedPartRoutines => "Decoded {0} {1} routines | {2}";

        public static MsgPattern<ApiHostUri> DecodingHostRoutines => "Decoding {0} routines";

        public static MsgPattern<Count,ApiHostUri> DecodedHostRoutines => "Decoded {0} {1} routines";

        public static MsgPattern<Count,Count> DecodedMachine => "Decoded {0} routines from {1} parts";

        public static MsgPattern<Count> CollectingBitstrings => "Collecting distinct bitstrings from {0} statements";

        public static MsgPattern<Count> CollectedBitstrings => "Collecting {0} distinct bitstrings";

        public static MsgPattern<FS.FileUri> LoadingStatements
            => "Loading statements from {0}";

        public static MsgPattern<Count,FS.FileUri> LoadedStatments
            => "Loading {0} statements from {1}";

        public static MsgPattern<Count,FS.FileUri> ProcessingStatments
            => "Processing {0} statements from {1}";

        public static MsgPattern<Count,FS.FileUri> ProcessedStatements
            => "Processed {0} statements from {1}";

        public static MsgPattern<Count> CreatingStatements => "Creating statements for {0} routines";

        public static MsgPattern<Count,ApiHostUri> CreatingHostStatements => "Creating {0} {1} routine productions";

        public static MsgPattern<Count,ApiHostUri> DecodedHostMembers => "Decoded {0} {1} members";

        public static MsgPattern<AsmMnemonic> MonicCodeParseFailed => "Attempt to parse mnemonic code for {0} failed";

        public static MsgPattern<string> CouldNotParseSigExpr => "Could not created a signature expression from {0}";

        public static MsgPattern<Count,Count> UnexpectedFieldCount => "{0} fields were expected and yet {1} were found";

        public static MsgPattern<FS.FileUri> CouldNotParseDocument => "Could not parse {0}";

        public static MsgPattern<TextRow,string> CouldNotParseStatementRow => "Could not parse statement from {0}: {1}";

        public static MsgPattern<Fence<char>> OpCodeFenceNotFound => "Op code fence {0} not found";

        public static MsgPattern<Count,Count> CollectedThumbprints => "Collected {0} distinct thumbprints from {1} statements";
    }
}