//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

public readonly struct ApiNames
{
    public const string TextApi = text + dot + core;

    public const string SymbolQuery = symbolic + dot + query;

    public const string Memory = memory;

    public const string LiteralKinds = literals + dot + kinds;

    public const string Arrays = collective + dot + arrays;

    public const string ArrayBuilder = collective + dot + arrays + dot + builder;

    public const string XArray = collective + dot + arrays + dot + extensions;

    public const string DataFlows = data + dot + flow;

    public const string DataModels = data + dot + models;

    public const string Rules = rules;

    public const string Nodes = data + dot +  nodes;

    public const string AppMsg = app + dot + msg;

    public const string AppErrors = app + dot + errors;

    public const string AppErrorMsg = app + dot + errors + dot + msg;

    public const string Scalars = primal + dot + scalars;

    public const string Lookups = lookups + dot + core;

    public const string Tuples = tuples;

    // ~~ Api
    // ~~ -----------------------------------------------------------------------------------------

    public const string ApiServices = api + dot + services;

    public const string ApiIdentity = api + dot + identity;

    public const string XApiIdentity = api + dot + identity + dot + extensions;

    public const string ApiIdentify = api + dot + identify;

    public const string ApiTestIdentity = api + dot + identity + dot + tests;

    public const string ApiIdentityReflector = api + dot + identity + dot + reflector;

    public const string ApiCatalogs = api + dot + catalogs;

    public const string ApiEnumCatalog = api + dot + catalogs + dot + enums;

    public const string ApiCatalogExtensions = api + dot + catalogs + dot + extensions;

    public const string ApiCatalogServices = api + dot + catalogs + dot + services;

    public const string ApiIdentities = api + dot + catalogs + dot + identities;

    public const string ApiQuery = api + dot + query;

    public const string ApiPartCatalogQuery = api + dot + query + dot + parts;

    public const string ApiHostQuery = api + dot + query + dot + hosts;

    public const string ApiJit = api + dot + jit;

    public const string ApiSpecs = api + dot + specs;

    public const string ApiCallMap = api + dot + calls + dot + "map";

    public const string ApiCallRoutes = api + dot + calls + dot + routes;

    public const string ApiCode = api + dot + "code";

    // ~~ Bitlogic
    // ~~ -----------------------------------------------------------------------------------------

    public const string BitLogicBits =  bits + logic;

    public const string BitLogicU8 = bitlogic + dot + u8;

    public const string BitLogicU16 = bitlogic + dot + u16;

    public const string BitLogicU32 = bitlogic + dot + u32;

    public const string BitLogicU64 = bitlogic + dot + u64;

    public const string BitLogicKinds = bitlogic + dot + kinds;

    public const string BitLogicScalar = bitlogic + dot + scalar;

    public const string BitLogicBytes = bitlogic + dot + bytes;

    // ~~ Blocks
    // ~~ -----------------------------------------------------------------------------------------

    public const string DataBlocks = blocks + dot + data;

    public const string CharBlocks = blocks + dot + chars;

    public const string SpanBlocks = blocks + dot + spans;

    public const string Spans = spans;

    public const string XSpans = spans + dot + extensions;

    // ~~ Cells
    // ~~ -----------------------------------------------------------------------------------------

    public const string Cells = cells;

    public const string CellDelegates = cells + dot + delegates;

    public const string CellOps = cells + dot + ops;

    public const string CellOpX = cells + dot + ops + dot + extensions;

    public const string CellOpKinds = cells + dot + ops + dot + kinds;

    public const string CellBuffers = cells + dot + buffers;

    public const string CellSource = cells + dot + source;

    public const string CellCopy = cells + dot + copy;

    public const string XCell = cells + dot + extensions;

    // ~~ Clr Runtime
    // ~~ -----------------------------------------------------------------------------------------

    const string ClrRuntime = clr + dot + runtime;

    public const string ClrType = ClrRuntime + dot + type;

    public const string ClrTypes = ClrRuntime + dot + types;

    public const string ClrEnum = ClrRuntime + dot + @enum;

    public const string ClrEnumLiteral = ClrRuntime + dot + @enum + dot + literal;

    public const string ClrStruct = ClrRuntime + dot + @struct;

    public const string ClrAssembly = ClrRuntime + dot + assembly;

    public const string ClrField = ClrRuntime + dot + field;

    public const string ClrMethod = ClrRuntime + dot + method;

    public const string ClrProperty = ClrRuntime + dot + property;

    public const string ClrHandles = ClrRuntime + dot + handles;

    public const string ClrMember = ClrRuntime + dot + member;

    public const string ClrQuery = ClrRuntime + dot + query;

    public const string XClrQuery = ClrRuntime + dot + query + dot + extensions;

    // ~~ Clr Metadata
    // ~~ -----------------------------------------------------------------------------------------

    const string ClrMetadata = clr + dot + metadata;

    public const string ClrArtifacts = ClrMetadata + dot + artifacts;

    public const string ClrRecords = ClrMetadata + dot + records;

    public const string ClrTypeCodes = ClrMetadata + dot + codes + dot + types;

    public const string ClrPrimitives = ClrMetadata + dot + primitives;

    public const string ClrEnums = ClrMetadata + dot + enums;

    public const string ClrSigs = ClrMetadata + dot + sigs;

    // ~~ Delegates
    // ~~ -----------------------------------------------------------------------------------------

    public const string Delegates = delegates;

    public const string DelegatesX = delegates + dot + extensions;

    // ~~ Db
    // ~~ -----------------------------------------------------------------------------------------

    public const string Db = db;

    public const string DbArtifacts = db + dot + artifacts;

    const string formatter = nameof(formatter);

    // ~~ Bits
    // ~~ -----------------------------------------------------------------------------------------

    public const string BitFormatter = bits + dot + formatter;

    public const string BitStream = bits + dot + stream;

    public const string BitParser = bits + dot + parser + dot;

    public const string BitFormatOptions = bits + dot + formatters + dot + options;

    public const string BitFieldParts = bits + dot + bitfields + dot + parts;

    public const string BitFieldSpecs = bits + dot + bitfields + dot + specs;

    // ~~ Memory
    // ~~ -----------------------------------------------------------------------------------------

    public const string MemoryStore = memory + dot + store;

    public const string MemoryReader = memory + dot + reader;

    public const string MemoryRefs = memory + dot + refs;

    public const string MemoryView = memory + dot + view;

    public const string Pointers = datatypes + dot + pointers;

    // ~~ Primal
    // ~~ -----------------------------------------------------------------------------------------

    public const string PrimalKinds = primal + dot + kinds;

    // ~~ Resources
    // ~~ -----------------------------------------------------------------------------------------

    public const string Resources = resources;

    public const string TextResources = resources + dot + text;


    // ~~ Symbolic
    // ~~ -----------------------------------------------------------------------------------------

    public const string Symbolic = symbolic;

    public const string SymbolicX = symbolic + dot + extensions;

    public const string SymbolicHex = symbolic + dot + hex;

    public const string SymbolStore = symbolic + dot + store;

    public const string SymbolicDigits = symbolic + dot + digits;

    public const string SymbolicTest = symbolic + dot + test;

    public const string SymbolicTests = symbolic + dot + tests;

    public const string Asci = symbolic + dot + asci;

    public const string AsciSymbols = symbolic + dot + asci + dot + symbols;

    public const string PermSymbolic = symbolic + dot + permutations;

    public const string PermSymbolicX = symbolic + dot + permutations + dot + extensions;

    // ~~ Wf
    // ~~ -----------------------------------------------------------------------------------------

    public const string Workflow = workflow;

    public const string WfShell = workflow + dot + shell;

    public const string WfEvents = workflow + dot + events;

    public const string WfControl = workflow + dot + control;

    public const string XWfShell = workflow + dot + shell + dot + extensions;

    // ~~ Text
    // ~~ -----------------------------------------------------------------------------------------

    public const string TextEncoders = text + dot + encoders;

    // ~~ Tables
    // ~~ -----------------------------------------------------------------------------------------

    public const string Tables = tables;

    public const string TableFields = tables + dot + fields;

    public const string TableRows = tables + dot + rows;

    public const string TableMaps = tables + dot + maps;

    public const string StringTables = tables + dot + strings;

    // ~~ Literals
    // ~~ -----------------------------------------------------------------------------------------
    public const string LiteralFields = literal + dot + fields;

    public const string TypedLiterals = literals + dot + typed;

    public const string Relations = relations;

    public const string CaseLogs = logs + dot + cases;

    public const string NumericKinds = numeric + dot + kinds;

    public const string NumericArrays = numeric + dot + arrays;

    public const string XNumericKind = numeric + dot + kinds + dot + extensions;

    public const string Widths = widths;

    public const string MemoryModels = memory + dot + models;

    public const string MemorySlots = memory + dot + slots;


    public const string VexPop = vex + dot + "pop";

    public const string Indexed = collective + dot + indexed;

    public const string Listings = collective + dot + listings;

    public const string Strings = collective + dot + strings;

    public const string Sets = collective + dot + sets;

    public const string CmdHosts = cmd + dot + hosts;

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

    public const string SFxSurrogates = sfunc + dot + surrogates;

    public const string SFxProjectors = sfunc + dot + projectors;

    public const string SFxFactories = sfunc + dot + functions + dot + factories;

    public const string FS = fs;

    public const string XFs = fs + dot + extensions;

    public const string Seq = seq;

    public const string SeqMap = seq + dot + map;

    public const string ApiParseBlocks = api + dot + blocks + parse;


    public const string ApiRuntime = api + dot + runtime;

    public const string Links = links;

    const string v512 = nameof(v512);

    public const string Vex512 = vex + dot + v512;

    public const string VexKinds = vex + dot + kinds;

    public const string VexLookup = vex + dot + lookups;

    public const string VexKindX = vex + dot + kinds + dot + extensions;

    public const string VexFpS = vex + dot + scalar + dot + fp;

    public const string VexReflex = vex + dot + reflex;

    public const string XVex = vex + dot + extensions;

    public const string Scripts = scripts;

    public const string Cmd = cmd + dot + core;

    public const string JsonDeps = runtime + dot + archives + dot + "dependencies";

    public const string BitSeqApi = bits + dot + seq + dot + api;

    public const string BitLogicU1 = ui + dot +  bitlogic + dot + u1;

    public const string BitLogicU2 = ui + dot + bitlogic + dot + u2;

    public const string BitLogicU3 = ui + dot + bitlogic + dot + u3;

    public const string BitLogicU4 = ui + dot + bitlogic + dot + u4;

    public const string BitLogicU5 = ui + dot + bitlogic + dot + u5;

    public const string BitLogicU6 = ui + dot + bitlogic + dot + u6;

    public const string BitLogicU7 = ui + dot + bitlogic + dot + u7;

    public const string BitLogicO8 = ui + dot + bitlogic + dot + u8;

    public const string BitSeq = bits + dot + seq;

    public const string AsmData = asm + dot + data;

    public const string AsmOpCodes = AsmData + dot + opcodes;

    public const string AsmLang = asm + dot + lang;

    public const string AsmOperands =  AsmLang + dot + operands;

    public const string AsmRegisters = asm + dot + registers;

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

    public const string ToolCmd = nameof(cmd) + dot + tools;

    public const string XCmdWorkers = cmd + dot + workers + dot + extensions;

    public const string CmdSpecs = cmd + dot + specs;

    public const string DynamicOperators = dynamic + dot + operators;

    public const string AlgorithmDynamic = dynamic + dot + algorithms;

    // ~~ LinqX
    // ~~ -----------------------------------------------------------------------------------------

    public const string LinqXPress = linq + dot + expressions;

    public const string LinqXQuery = linq + dot + expressions + dot + query;

    public const string LinqXFunc = linq + dot + expressions + dot + functions;

    public const string LinqXFuncX = linq + dot + expressions + dot + extensions;

    public const string gmath =  math + dot + generic;

    public const string algorithms = nameof(algorithms);

    public const string AlG = math + dot + generic + dot + algorithms;

    public const string XAlG = math + dot + generic + dot + algorithms + dot + extensions;

    public const string Partition = math + dot + partition;

    public const string CheckClose = checks + dot + "close";

    public const string CheckSpans = checks + dot + spans;

    public const string LanguageModels = lang + dot + models;

    public const string CsLang = lang + dot + cs;

    public const string CsRender = lang + dot + cs + dot + render;

    public const string CsBuilder = lang + dot + cs + dot + builder;

    public const string LangPrototypes = lang + dot + "prototypes";

    public const string Cil = cil + dot + api;

    public const string CilTableBuilder = cil + dot + tables + dot + builder;

    public const string CilTables = cil + dot + tables;

    public const string FilePathParser = parsers + dot + files + dot + paths;

    public const string SyntaxModels = syntax + dot + models;

    public const string SyntaxParsers = syntax + dot + parsers;

    public const string SyntaxParserCases = syntax + dot + parsers + dot + cases;

    public const string BufferSegments = buffers + dot + segments;

    public const string StateBuffers = buffers + dot + states;

    public const string PinnedBuffers = buffers + dot + "pinned";

    public const string WfArchives = wf + dot + archives;

}