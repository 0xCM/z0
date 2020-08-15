//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct OpCodeExpressions
    {
        public const string JaRel8 = "77 cb";

        public const string JaRel16 = "0F 87 cw";

        public const string JaRel32 = "0F 87 cd";

        public const string JaeRel8 = "73 cb";

        public const string JaeRel16 = "0F 83 cw";

        public const string JaeRel32 = "0F 83 cd";
    }
}