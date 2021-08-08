//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct SigMarkers
        {
            [TextMarker]
            public const string k1 = "{K}";

            [TextMarker]
            public const string z = "{z}";

            [TextMarker]
            public const string sae = "{sae}";

            [TextMarker]
            public const string er = "{er}";

            [TextMarker]
            public const string bcast32 = "bcast32";

            [TextMarker]
            public const string bcast64 = "bcast64";
        }
    }
}