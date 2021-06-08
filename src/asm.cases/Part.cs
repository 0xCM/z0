//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCases)]
namespace Z0.Parts
{
    public sealed class AsmCases : Part<AsmCases>
    {
        public static AsmCaseAssets Assets => new AsmCaseAssets();
    }
}

namespace Z0
{
    using Z0.Asm;

    [ApiHost]
    public static partial class XTend
    {

    }

    [ApiComplete]
    partial struct Msg
    {
       public static MsgPattern<Count,AsmOcPrototype> DefiningExpressions => "Defining {0} expressions of kind {1}";

        public static MsgPattern<Count,AsmOcPrototype> DefinedExpressions => "Defining {0} expressions of kind {1}";
    }
}