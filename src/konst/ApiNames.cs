//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;

    using A = ApiNameAtoms;

    [ApiNameProvider]
    readonly struct ApiNames
    {
        public const string AppMsg = app + dot + msg;

        public const string AppErrors = app + dot + errors;

        public const string AppErrorMsg = app + dot + errors + dot + msg;

        public const string Scalars = primal + dot + scalars;

        public const string Lookups = lookups + dot + core;

        public const string Tuples = tuples;

        // ~~ Api
        // ~~ -----------------------------------------------------------------------------------------

        public const string ApiIdentity = api + dot + identity;

        public const string ApiIdentityX = api + dot + identity + dot + extensions;

        public const string ApiIdentify = api + dot + identify;

        public const string ApiTestIdentity = api + dot + identity + dot + tests;

        const string reflector = nameof(reflector);

        public const string ApiIdentityReflector = api + dot + identity + dot + reflector;

        public const string ApiCatalogs = api + dot + catalogs;

        public const string ApiEnumCatalog = api + dot + catalogs + dot + enums;

        public const string ApiCatalogExtensions = api + dot + catalogs + dot + extensions;

        public const string ApiCatalogServices = api + dot + catalogs + dot + services;

        public const string ApiIdentities = api + dot + catalogs + dot + identities;

        public const string ApiQuery = api + dot + query;

        public const string ApiPartCatalogQuery = api + dot + query + dot + parts;

        public const string ApiHostMemberQuery = api + dot + query + dot + hosts;

        // ~~ Bitlogic
        // ~~ -----------------------------------------------------------------------------------------

        public const string BitLogicBits = bitlogic + dot + bits;

        public const string BitLogicU1 = bitlogic + dot + u1;

        public const string BitLogicU2 = bitlogic + dot + u2;

        public const string BitLogicU3 = bitlogic + dot + u3;

        public const string BitLogicU4 = bitlogic + dot + u4;

        public const string BitLogicU5 = bitlogic + dot + u5;

        public const string BitLogicU6 = bitlogic + dot + u6;

        public const string BitLogicU7 = bitlogic + dot + u7;

        public const string BitLogicO8 = bitlogic + dot + octets;

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

        // ~~ Cells
        // ~~ -----------------------------------------------------------------------------------------

        public const string Cells = cells;

        public const string CellDelegates = cells + dot + delegates;

        public const string CellOps = cells + dot + ops;

        public const string CellOpX = cells + dot + ops + dot + extensions;

        public const string CellOpKinds = cells + dot + ops + dot + kinds;

        public const string CellBuffers = cells + dot + buffers;

        public const string CellSource = cells + dot + source;

        public const string CellsX = cells + dot + extensions;


        // ~~ Clr Runtime
        // ~~ -----------------------------------------------------------------------------------------

        const string ClrRuntime = clr + dot + runtime;

        public const string ClrType = ClrRuntime + dot + type;

        public const string ClrTypes = ClrRuntime + dot + types;

        public const string ClrEnum = ClrRuntime + dot + @enum;

        public const string ClrEnums = ClrRuntime + dot + enums + dot + api;

        public const string ClrEnumLiteral = ClrRuntime + dot + @enum + dot + literal;

        public const string ClrStruct = ClrRuntime + dot + @struct;

        public const string ClrAssembly = ClrRuntime + dot + assembly;

        public const string ClrField = ClrRuntime + dot + field;

        public const string ClrMethod = ClrRuntime + dot + method;

        public const string ClrProperty = ClrRuntime + dot + property;


        public const string ClrHandles = ClrRuntime + dot + handles;

        public const string ClrMember = ClrRuntime + dot + member;

        public const string ClrReflexSvc = ClrRuntime + dot + reflex + dot + svc;

        public const string ClrReflex = ClrRuntime + dot + reflex;

        public const string XRelflex = ClrRuntime + dot + reflex + dot + extensions;

        // ~~ Clr Metadata
        // ~~ -----------------------------------------------------------------------------------------

        const string ClrMetadata = clr + dot + metadata;

        public const string ClrArtifacts = ClrMetadata + dot + artifacts;

        public const string ClrRecords = ClrMetadata + dot + records;

        public const string ClrPrimitives = ClrMetadata + dot + primitives;

        // ~~ Delegates
        // ~~ -----------------------------------------------------------------------------------------

        public const string Delegates = delegates;

        public const string DelegatesX = delegates + dot + extensions;

        // ~~ Db
        // ~~ -----------------------------------------------------------------------------------------

        public const string Db = db;

        public const string DbArtifacts = db + dot + artifacts;

        // ~~ Bits
        // ~~ -----------------------------------------------------------------------------------------

        public const string BitFormatter = bits + dot + formatters;

        public const string BitStream = bits + dot + stream;

        public const string BitParser = bits + dot + parser + dot;

        public const string BitFormatOptions = bits + dot + formatters + dot + options;

        public const string BitFieldParts = bits + dot + bitfields + dot + parts;

        public const string BitFieldSpecs = bits + dot + bitfields + dot + specs;

        // ~~ Linq
        // ~~ -----------------------------------------------------------------------------------------

        public const string LinqXPress = linq + dot + expressions;

        public const string LinqXQuery = linq + dot + expressions + dot + query;

        public const string LinqXFunc = linq + dot + expressions + dot + functions;

        public const string LinqXFuncX = linq + dot + expressions + dot + extensions;

        // ~~ Memory
        // ~~ -----------------------------------------------------------------------------------------

        public const string MemStore = A.memory + dot + store;

        public const string MemReader = A.memory + dot + reader;

        public const string MemRefs = A.memory + dot + refs;

        public const string MemCopy = A.memory + dot + copy;

        public const string MemView = A.memory + dot + view;

        public const string Pointers = A.memory + dot + pointers;

        public const string StringRefs = A.memory + dot + refs + dot + strings;

        // ~~ Primal
        // ~~ -----------------------------------------------------------------------------------------

        public const string PrimalKinds = primal + dot + kinds;

        // ~~ Resources
        // ~~ -----------------------------------------------------------------------------------------

        public const string Resources = resources;

        public const string TextResources = resources + dot + A.text;


        // ~~ SFunc
        // ~~ -----------------------------------------------------------------------------------------

        public const string SFxSurrogates = sfunc + dot + surrogates;

        public const string SFxProjectors = sfunc + dot + projectors;

        // ~~ Symbolic
        // ~~ -----------------------------------------------------------------------------------------

        public const string Symbolic = symbolic;

        public const string SymbolicX = symbolic + dot + extensions;

        public const string SymbolicHex = symbolic + dot + hex;

        public const string SymbolStore = symbolic + dot + store;

        public const string SymbolicDigits = symbolic + dot + digits;

        public const string SymbolicTest = symbolic + dot + test;

        public const string SymbolicTests = symbolic + dot + tests;

        public const string Asci = symbolic + dot + A.asci;

        public const string AsciSymbols = symbolic + dot + A.asci + dot + symbols;

        public const string PermSymbolic = symbolic + dot + permutations;

        public const string PermSymbolicX = symbolic + dot + permutations + dot + extensions;

        // ~~ Wf
        // ~~ -----------------------------------------------------------------------------------------

        public const string Workflow = workflow;

        public const string WfShell = workflow + dot + shell;

        public const string WfControl = workflow + dot + control;

        public const string WfShellX = workflow + dot + shell + dot + extensions;

        // ~~ Text
        // ~~ -----------------------------------------------------------------------------------------

        public const string TextEncoders = A.text + dot + encoders;

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

        public const string NumericKindX = numeric + dot + kinds + dot + extensions;

        public const string Widths = widths;

        public const string MemoryModels = A.memory + dot + models;

        public const string MemorySlots = A.memory + dot + slots;

        public const string VexKinds = vex + dot + kinds;

        public const string VexKindX = vex + dot + kinds + dot + extensions;

        public const string VexFpS = vex + dot + fp + dot + scalar;

        public const string VexReflex = vex + dot + reflex;

        public const string VexPop = vex + dot + "pop";

        public const string Indexed = collective + dot + indexed;

        public const string Listings = collective + dot + listings;

        public const string Seq = collective + dot + seq;
    }
}