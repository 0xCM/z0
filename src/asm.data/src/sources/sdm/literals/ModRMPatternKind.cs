//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum ModRMPatternKind : byte
        {
            None = 0,

            RmR = 1,

            RmW = 2,

            RmRW = 3,

            RegR = 4,

            RegW = 5,

            RegRW = 6,

            RmRMust11 = 7,

            RmWNot11 = 8
        }
    }
}