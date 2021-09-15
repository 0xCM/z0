//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    [LiteralProvider]
    public readonly struct AsmFieldNames
    {
        public const string Size = "Size";

        public const string DecoderNamespace = "DecoderNamespace";

        public const string Predicates = "Predicates";

        public const string DecoderMethod = "DecoderMethod";

        public const string HasCompleteDecoder = "hasCompleteDecoder";

        public const string Namespace = "Namespace";

        public const string OutOperandList = "OutOperandList";

        public const string InOperandList = "InOperandList";

        public const string AsmString = "AsmString";
    }
}