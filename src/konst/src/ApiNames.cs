//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;

    using A = ApiNameAtoms;

    [LiteralProvider]
    readonly struct ApiNames
    {
        public const string ApiIdentity = api + dot + identity;

        public const string ApiIdentityX = api + dot + identity + dot + extensions;

        public const string ApiIdentify = api + dot + "identify";

        public const string ApiCatalogs = api + dot + catalogs;

        public const string ApiCatalogServices = api + dot + catalogs + dot + services;

        public const string BitFormatter = bits + dot + formatters;

        public const string BitStream = bits + dot + stream;

        public const string BitParser = bits + dot + parser + dot;

        public const string BitFormatOptions = bits + dot + formatters + dot + options;

        public const string BitFieldParts = bitfields + dot + parts;

        public const string BitFieldSpecs = bitfields + dot + specs;

        public const string Cells = cells + dot + api;

        public const string CellDelegates = cells + dot + delegates;

        public const string CellBuffers = cells + dot + buffers;

        public const string CellSource = cells + dot + source;

        public const string Delegates = delegates;

        public const string SymHex = symbolic + dot + hex;

        public const string SFxSurrogates = sfunc + dot + surrogates;

        public const string SFxProjectors = sfunc + dot + projectors;

        public const string DelegatesX = Delegates + dot + extensions;

        public const string XPress = expressions;

        public const string XFunc = expressions + dot + functions;

        public const string XFuncX = XFunc + dot + extensions;

        public const string XQuery = expressions + dot + query;

        public const string DataBlocks = blocks + dot + data;

        public const string CharBlocks = blocks + dot + chars;

        public const string BitLogic = bits + dot + logic;

        public const string BitLogicBits = BitLogic + dot + bits;

        public const string BitLogicU1 = BitLogic + dot + u1;

        public const string BitLogicU2 = BitLogic + dot + u2;

        public const string BitLogicU3 = BitLogic + dot + u3;

        public const string BitLogicU4 = BitLogic + dot + u4;

        public const string BitLogicU5 = BitLogic + dot + u5;

        public const string BitLogicU6 = BitLogic + dot + u6;

        public const string BitLogicU7 = BitLogic + dot + u7;

        public const string BitLogicO8 = BitLogic + dot + octets;

        public const string BitLogicU8 = BitLogic + dot + u8;

        public const string BitLogicU16 = BitLogic + dot + u16;

        public const string BitLogicU32 = BitLogic + dot + u32;

        public const string BitLogicU64 = BitLogic + dot + u64;

        public const string BitLogicKinds = BitLogic + dot + kinds;

        public const string BitLogicScalar = BitLogic + dot + scalar;

        public const string BitLogicBytes = BitLogic + dot + bytes;

        public const string Resources = data + dot + resources;

        public const string TextResources = Resources + dot + A.text;

        public const string Tables = tables;

        public const string TableFields = tables + dot + fields;

        public const string TableRows = tables + dot + rows;

        public const string TableMaps = tables + dot + maps;

        public const string WfCore = wf + dot + core;

        public const string WfCmd = wf + dot + cmd;

        public const string PrimalKinds = primal + dot + kinds;

        public const string PrimalKindBits = primal + dot + kinds + dot + bitfield;

        public const string MemoryStore = A.memory + dot + store;

        public const string TextEncoders = A.text + dot + encoders;

        public const string StringTables = data + dot + "stringtables";

        public const string DbFiles = "archives" + dot + "db";

        const string signatures = nameof(signatures);

        public const string Signatures = signatures;
    }
}