"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Vars = exports.ToolId = void 0;
exports.default = complus;
exports.ToolId = 'complus';
exports.Vars = {
    Tool: exports.ToolId,
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
};
//# sourceMappingURL=complus.js.map