"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Doc = exports.Args = void 0;
exports.default = crossgen;
let tool = 'crossgen';
exports.Args = [
    tool,
    [
        '/?',
        '/help',
        '/verbose',
        '/silent',
        '/nologo',
        '/nowarnings',
        ['/in', '']
    ]
];
exports.Doc = [
    tool,
    `
    Usage: crossgen [args] <assembly name>
    /? or /help          - Display this screen
    /nologo              - Prevents displaying the logo
    /nowarnings          - Prevents displaying warning messages
    /silent              - Do not display completion message
    /verbose             - Display verbose information
    @response.rsp        - Process command line arguments from specified response file
    /in <file>           - Specifies input filename (optional)
    /out <file>          - Specifies output filename (optional)
    /r <file>            - Specifies a trusted platform assembly reference; cannot be used with /p
    /p <path[;path]>     - List of paths containing target platform assemblies; cannot be used with /r
    /Platform_Resource_Roots <path[;path]> - List of paths containing localized assembly directories
    /App_Paths <path[;path]> - List of paths containing user-application assemblies and resources
    /App_Ni_Paths <path[;path]> - List of paths containing user-application native images Must be used with /CreatePDB switch
    /MissingDependenciesOK - Specifies that crossgen should attempt not to fail if a dependency is missing.
    /JITPath <path> - Specifies the absolute file path to JIT compiler to be used.
    /ReadyToRun          - Generate images resilient to the runtime and dependency versions
    /LargeVersionBubble  - Generate image with a version bubble including all input assemblies
    /CreatePDB <Dir to store PDB> [/lines [<search path for managed PDB>] ] When specifying /CreatePDB, the native image should be created first, and <assembly name> should be the path to the NI.
    /DiasymreaderPath <Path to diasymreader.dll> - Specifies the absolute file path to diasymreader.dll to be used.
    `
];
//# sourceMappingURL=crossgen.js.map