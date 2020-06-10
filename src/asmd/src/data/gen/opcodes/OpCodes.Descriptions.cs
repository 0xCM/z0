//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    partial class OpCodes
    {
        public class Descriptions
        {
            public const string JaRel8 = "Jump short if above (CF=0 and ZF=0)";

            public const string JaRel16 = "Jump near if above (CF=0 and ZF=0)";

            public const string JaRel32 = "Jump near if above (CF=0 and ZF=0)";

            public const string JaeRel8 = "Jump short if above or equal (CF=0)";

            public const string JaeRel16 = "Jump near if above or equal (CF=0)";

            public const string JaeRel32 = "Jump near if above or equal (CF=0)";
        }
    }
}