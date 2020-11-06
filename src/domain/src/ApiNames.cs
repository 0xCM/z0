//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

[ApiNameProvider]
readonly struct ApiNames
{
    public const string Signatures = signatures;

    public const string Cmd = cmd + dot + core;

    public const string CmdPatterns = cmd + dot + patterns;

    public const string CmdRunners = cmd + dot + "runners";

    public const string sequences = nameof(sequences);

    public const string FilePathParser = parsers + dot + files + dot + paths;

    public const string EnumCatalogs = enums + dot + catalogs;

    public const string SyntaxModels = syntax + dot + models;

    public const string SyntaxParsers = syntax + dot + parsers;

    public const string SyntaxParserCases = syntax + dot + parsers + dot + cases;

    public const string BufferSegments = buffers + dot + segments;

    public const string StateBuffers = buffers + dot + states;

    public const string FixedBuffers = buffers + dot + @fixed;

    public const string JsonData = data + dot + json;

    public const string ApiData = api + dot + data;

    public const string ApiRuntime = api + dot + runtime;

    public const string ApiSigs = api + dot + signatures;

    const string samples = nameof(samples);

    const string catalog = nameof(catalog);

    public const string ToolCmd = nameof(cmd) + dot + tools;

    public const string XCmdWorkers = cmd + dot + workers + dot + extensions;

    public const string XCmdSamples = cmd + dot + samples + dot + extensions;

    public const string CmdSpecs = cmd + dot + specs;

    public const string XCmdSpecs = cmd + dot + specs + dot + extensions;

    public const string JsonDeps = "builds" + dot + archives + dot + "dependencies";

    public const string Workers = workers;
}

[ToolNameProvider]
readonly struct ToolNames
{
    public const string echo = nameof(echo);

    public const string dumpbin = nameof(dumpbin);

    public const string procdump = nameof(procdump);

    public const string ildasm = nameof(ildasm);

    public const string ilasm = nameof(ilasm);
}