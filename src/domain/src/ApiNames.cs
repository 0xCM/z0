//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

[ApiNameProvider]
readonly struct ApiNames
{
    public const string Signatures = signatures;


    public const string sequences = nameof(sequences);

    public const string EnumCatalogs = enums + dot + catalogs;

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


    public const string WfServices = workflow + dot + services;
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