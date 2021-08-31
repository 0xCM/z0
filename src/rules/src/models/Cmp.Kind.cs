//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public enum CmpKind : byte
        {
            EQ = 0,

            LT = 1,

            LE = 2,

            NEQ = 4,

            NLT = 5,

            NGT,

            GT,

            GE
        }
    }
}