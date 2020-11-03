//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

using static ApiNameParts;
using static CmdCodeParts;

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
