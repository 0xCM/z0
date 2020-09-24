//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Konst)]

namespace Z0.Parts
{
    public sealed class Konst : Part<Konst>
    {

    }

}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }

    [LiteralProvider]
    readonly struct ApiNames
    {
        public const string Api = "api";

        public const string Wf = "wf";

        public const string Tables = "tables";

        public const string SymbolicHex = "symbolic.hex";

        public const string SfuncSurrogates = "sfuncs.surrogates";

        public const string SfuncProjectors = "sfuncs.projectors";
    }
}