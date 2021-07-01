//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [ApiComplete("intel.sdm.formatmarkers")]
        public readonly struct FormatMarkers
        {
            public static Marker register1_to_register2 => "register1 to register2";

            public static Marker register2_to_register1 => "register2 to register1";

            public static Marker memory_to_register => "memory to register";

            public static Marker register_to_memory => "register to memory";

            public static Marker qwordregister1_to_qwordregister2 => "qwordregister1 to qwordregister2";

            public static Marker memory64_to_qwordregister => "memory64 to qwordregister";

            public static Marker qwordregister_to_memory64 => "qwordregister to memory64";

            public static Marker immediate_to_register => "immediate to register";

            public static Marker immediate_to_qwordregister => "immediate to qwordregister";

            public static Marker immediate_to_RAX => "immediate to RAX";

            public static Marker immediate_to_AL_or_AX_or_EAX => "immediate to AL, AX, or EAX";

            public static Marker immediate_to_memory => "immediate to memory";

            public static Marker immediate8_to_memory64 => "immediate8 to memory64";

            public static Marker immediate32_to_memory64 => "immediate32 to memory64";

            public static Marker immediate32_to_qwordregister => "immediate32 to qwordregister";

            public static Marker immediate32_to_RAX => "immediate32 to RAX";
        }
    }
}