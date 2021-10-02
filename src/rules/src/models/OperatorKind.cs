//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RuleModels
    {
        public enum OperatorKind : byte
        {
            None = 0,

            Not,

            And,

            Or,

            Xor,

            Assign,

            Add,

            Sub,

            Eq,

            Neq,

            Gt,

            GtEq,

            Lt,

            LtEq,

            Inc,

            Dec,
        }
    }
}