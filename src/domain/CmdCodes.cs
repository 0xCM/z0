//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;
    using static CmdCodeAtoms;

    public readonly struct CmdCodeAtoms
    {
        public const string ArgSpec = ":";

        public const string FlagSpec = "--";

        public const string OpenList = "(";

        public const string CloseList = ")";

        public const string DelimitList = ";";

        public const string DelimitSubCmd = " ";

        public const string LeftRequire = "<";

        public const string RightRequire = ">";

        /// <summary>
        /// Semantic separator
        /// </summary>
        public const string SSep = "-";

        public const string res = nameof(res);
    }

    readonly struct CmdCodes
    {
        const string summaries = nameof(summaries);

        const string ApiSummaries = api + SSep + summaries;

        const string AsmOpCodes = api + SSep + opcodes;

        const string index = nameof(index);

        public const string EmitRes = FlagSpec + emit + DelimitSubCmd + res;

        public const string EmitApiSummaries = FlagSpec + emit + DelimitSubCmd + ApiSummaries;

        public const string EmitAsmOpCodes = FlagSpec + emit + DelimitSubCmd + AsmOpCodes;

        public const string EmitHexIndex = FlagSpec + emit + DelimitSubCmd + api + SSep + hex + SSep + index;
    }
}