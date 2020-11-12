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



    const string samples = nameof(samples);

    const string catalog = nameof(catalog);

    public const string ToolCmd = nameof(cmd) + dot + tools;

    public const string XCmdWorkers = cmd + dot + workers + dot + extensions;


    public const string CmdSpecs = cmd + dot + specs;


    public const string Workers = workers;


    public const string WfServices = workflow + dot + services;
}