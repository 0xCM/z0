//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

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

    public const string XCmdWorkers = api + dot + cmd + dot + workers;

    public const string XCmdSamples = api + dot + cmd + dot + samples;

    public const string XCmdCatalog = api + dot + cmd + dot + catalog;

    public const string ApiSigs = api + dot + signatures;

    const string samples = nameof(samples);

    const string catalog = nameof(catalog);
}
