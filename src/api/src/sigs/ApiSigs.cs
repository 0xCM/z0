//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost(ApiNames.Sigs, true)]
    public readonly partial struct ApiSigs
    {
        const string ReturnIndicator = "@return";

        const string Arrow = " -> ";

        const string OperandLead = "::";

        const string TypeParamOpen = "{";

        const string TypeParamClose = "}";

        const string TypeParamSep = ", ";
    }
}