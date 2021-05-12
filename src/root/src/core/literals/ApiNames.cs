//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

public readonly struct ApiNames
{
    public const string Memory = memory;

    public const string Arrays = collective + dot + arrays;

    public const string ArrayBuilder = collective + dot + arrays + dot + builder;

    public const string AppMsg = app + dot + msg;

    public const string AppErrors = app + dot + errors;

    public const string AppErrorMsg = app + dot + errors + dot + msg;

    public const string Lookups = lookups + dot + core;

    public const string Tuples = tuples;

    public const string ApiQuery = api + dot + query;


    public const string ApiCode = api + dot + "code";

    // ~~ Cells
    // ~~ -----------------------------------------------------------------------------------------

    public const string Cells = cells;

    public const string CellDelegates = cells + dot + delegates;

    public const string CellOps = cells + dot + ops;

    public const string CellCopy = cells + dot + copy;

    public const string XCell = cells + dot + extensions;

    // ~~ Clr Runtime
    // ~~ -----------------------------------------------------------------------------------------

    public const string ClrLiteralKinds = clr + literals + dot + kinds;

    public const string ClrHandles = clr + dot + handles;

    public const string Clr = clr;

    public const string ClrPrimitives = clr + dot + primitives;

    public const string ClrEnums = clr + dot + enums;


    // ~~ Delegates
    // ~~ -----------------------------------------------------------------------------------------

    public const string Delegates = delegates;


    // ~~ Db
    // ~~ -----------------------------------------------------------------------------------------


    const string formatter = nameof(formatter);

    // ~~ Bits
    // ~~ -----------------------------------------------------------------------------------------

    public const string BitFormatter = bits + dot + formatter;

    public const string BitParser = bits + dot + parser;

    public const string BitFormatOptions = bits + dot + formatters + dot + options;

    public const string MemoryReader = memory + dot + reader;


    public const string Pointers = datatypes + dot + pointers;


    public const string Resources = resources;

    // ~~ Symbolic
    // ~~ -----------------------------------------------------------------------------------------


    public const string Asci = symbolic + dot + asci;

    public const string AsciSymbols = symbolic + dot + asci + dot + symbols;


    // ~~ Wf
    // ~~ -----------------------------------------------------------------------------------------

    public const string WfShell = workflow + dot + shell;

    public const string WfEvents = workflow + dot + events;

    public const string WfControl = workflow + dot + control;


    public const string ClrLiteralFields = clr + literal + dot + fields;

    public const string Relations = relations;

    public const string NumericArrays = numeric + dot + arrays;

    public const string Widths = widths;

    public const string Utf8Data = text + dot + utf8;

    public const string ConstBytes256 = @const + dot + bytes + dot + n256;

    public const string ConstBytesReader = @const + dot + bytes + dot + reader;

    public const string ConstBytesCache = @const + dot + bytes + dot + cache;

    public const string GridCalcs = grid + dot + "calcs";

    public const string GridMetrics = grid + dot + metrics;

    public const string Grids = grids;

    public const string XKinds = kinds + dot + extensions;

    // ~~ SFunc
    // ~~ -----------------------------------------------------------------------------------------

    public const string SFx = sfunc + dot + core;

    public const string XSFx = sfunc + dot + core + extensions;


    public const string Seq = seq;


    const string v512 = nameof(v512);

    public const string Vex512 = vex + dot + v512;

    public const string VexReflex = vex + dot + reflex;

    public const string Cmd = cmd + dot + core;

    public const string BitSeqApi = bits + dot + seq + dot + api;

    public const string BitSeq = bits + dot + seq;


    public const string AsmSemanticRender = asm + dot + semantic + dot + render;

    public const string AsmSemanticArchive = asm + dot + semantic + dot + archive;

    public const string FxSlots = fx + dot + slots;

    public const string dot = ApiNameParts.dot;

    public const string Sigs = sigs;

    public const string sequences = nameof(sequences);

    public const string EnumCatalogs = enums + dot + catalogs;

    public const string JsonData = data + dot + json;

    const string samples = nameof(samples);

    const string catalog = nameof(catalog);

    public const string Algorithms = algorithms;


    // ~~ LinqX
    // ~~ -----------------------------------------------------------------------------------------

    public const string LinqXPress = linq + dot + expressions;

    public const string LinqXQuery = linq + dot + expressions + dot + query;

    public const string LinqXFunc = linq + dot + expressions + dot + functions;

    public const string LinqXFuncX = linq + dot + expressions + dot + extensions;

    public const string algorithms = nameof(algorithms);

    public const string Partition = math + dot + partition;

    public const string CheckClose = checks + dot + "close";

    public const string Cil = cil + dot + api;

    public const string CilTableBuilder = cil + dot + tables + dot + builder;

    public const string CilTables = cil + dot + tables;

    public const string FilePathParser = parsers + dot + files + dot + paths;

    public const string StaticBuffers = buffers + dot + "static";
}