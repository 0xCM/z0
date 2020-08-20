import * as z0 from "./Tools"
declare let complus: "./complus"
export default complus
export let ToolId:z0.ToolId = 'complus'

export type Var =
    | 'COMPlus_JitDiffableDasm'
    | 'COMPlus_JitDisasm'
    | 'COMPlus_JitDump'
    | 'COMPlus_JitDumpASCII'
    | 'COMPlus_JitEHDump'
    | 'COMPlus_JitGCDump'
    | 'COMPlus_JitNoForceFallback'
    | 'COMPlus_TieredCompilation'
    | 'COMPlus_JitEnableNoWayAssert'
    | 'COMPlus_JitRequired'
    | 'COMPlus_JitTimeLogFile'
    | 'COMPlus_JitTimeLogFileCsv'
    | 'COMPlus_JitUnwindDump'
    | 'COMPlus_NgenDisasm'
    | 'COMPlus_NgenDump'
    | 'COMPlus_NgenUnwindDump'
    | 'COMPlus_NgenEHDump'

export let Vars: z0.ToolVars<Var> = {
    Tool: ToolId,
    Values: [
        ['COMPlus_JitDiffableDasm', 'set to 1 to tell the JIT to avoid printing things like pointer values that can change from one invocation to the next, so that the disassembly can be more easily compared'],
        ['COMPlus_JitDisasm', `dump a disassembly listing of each method`],
        ['COMPlus_JitDump', `dump lots of useful information about what the JIT is doing`],
        ['COMPlus_JitEHDump', `dump the exception handling tables`],
        ['COMPlus_JitGCDump', `dump the GC information`],
        ["COMPlus_JitNoForceFallback", ``],
        ["COMPlus_TieredCompilation", ``],
        ['COMPlus_JitTimeLogFile', `this specifies a log file to which timing information is written`],
        ['COMPlus_JitTimeLogFileCsv', `this specifies a log file to which summary timing information can be written, in CSV form`]
    ]
}
