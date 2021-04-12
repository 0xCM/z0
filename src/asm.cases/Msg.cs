//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Asm;

    [ApiComplete]
    partial struct Msg
    {
       public static MsgPattern<Count,AsmSigKind> DefiningExpressions => "Defining {0} expressions of kind {1}";

        public static MsgPattern<Count,AsmSigKind> DefinedExpressions => "Defining {0} expressions of kind {1}";
    }
}