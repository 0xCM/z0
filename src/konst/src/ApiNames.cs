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
        public const string SymHex = symbolic + dot + hex;

        public const string SFxSurrogates = sfunc + dot + surrogates;

        public const string SFxProjectors = sfunc + dot + projectors;

        public const string ApiIdentity = api + dot + identity;

        public const string ApiIdentityX = ApiIdentity + dot + extensions;

        public const string Delegates = delegates;

        public const string DelegatesX = Delegates + dot + extensions;

        public const string XPress = expressions;

        public const string XFunc = expressions + dot + functions;

        public const string XFuncX = XFunc + dot + extensions;

        public const string XQuery = expressions + dot + query;

        public const string BitFormatter = bits + dot + formatters;

        public const string BitStream = bits + dot + stream;

        public const string BitParser = bits + dot + parser + dot;

        public const string BitFormatOptions = bits + dot + formatters + dot + options;

        public const string DataBlocks = blocks + dot + data;

        public const string CharBlocks = blocks + dot + chars;

        public const string BitLogic = bits + dot + logic;

        public const string BitLogicBits = BitLogic + dot + bits;

        public const string BitLogicKinds = BitLogic + dot + kinds;

        public const string BitLogicScalar = BitLogic + dot + scalar;

        public const string BitLogicBytes = BitLogic + dot + bytes;

        public const string Resources = resources;

        public const string TextResources = Resources + dot + A.text;

        public const string Tables = tables;

        public const string TableFields = tables + dot + fields;

        public const string TableRows = tables + dot + rows;

        public const string TableMaps = tables + dot + maps;

        public const string WfCore = wf + dot + core;

        public const string WfCmd = wf + dot + cmd;
    }
}