//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [LiteralProvider]
    readonly struct ApiNames
    {
        const string dot = AsciCharText.Dot;

        const string api = nameof(api);

        const string bits = nameof(bits);

        const string blocks = nameof(blocks);

        const string bytes = nameof(bytes);

        const string @char = "char";

        const string chars = nameof(chars);

        const string cmd = nameof(cmd);

        const string core = nameof(core);

        const string data = nameof(data);

        const string delegates = nameof(delegates);

        const string expressions = nameof(expressions);

        const string extensions = nameof(extensions);

        const string identity = nameof(identity);

        const string formatters = nameof(formatters);

        const string functions = nameof(functions);

        const string fields = nameof(fields);

        const string hex = nameof(hex);

        const string kinds = nameof(kinds);

        const string logic = nameof(logic);

        const string rows = nameof(rows);

        const string resources = nameof(resources);

        const string sfunc = nameof(sfunc);

        const string surrogates = nameof(surrogates);

        const string symbolic = nameof(symbolic);

        const string scalar = nameof(scalar);

        const string projectors = nameof(projectors);

        const string query = nameof(query);

        const string options = nameof(options);

        const string text = nameof(text);

        const string tables = nameof(tables);

        const string wf = nameof(wf);

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

        public const string BitFormatter = bits + dot + formatters + dot + api;

        public const string BitFormatOptions = bits + dot + formatters + dot + options;

        public const string DataBlocks = blocks + dot + data;

        public const string CharBlocks = blocks + dot + chars;

        public const string BitLogic = bits + dot + logic;

        public const string BitLogicBits = BitLogic + dot + bits;

        public const string BitLogicKinds = BitLogic + dot + kinds;

        public const string BitLogicScalar = BitLogic + dot + scalar;

        public const string BitLogicBytes = BitLogic + dot + bytes;

        public const string Resources = resources;

        public const string TextResources = Resources + dot + text;

        public const string Tables = tables;

        public const string TableFields = tables + dot + fields;

        public const string TableRows = tables + dot + rows;

        public const string WfCore = wf + dot + core;

        public const string WfCmd = wf + dot + cmd;
    }
}