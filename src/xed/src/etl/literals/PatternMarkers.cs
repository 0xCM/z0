//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    enum Mode : byte
    {
        None = 0,

        Mode16 = 1,

        Mode32 = 2,

        Mode64 = 3,

        Not64 = 4,
    }

    [ApiType]
    readonly struct XedPatternMarkers
    {
        public static Label<Mode> Mode16 => Labels.define(Mode.Mode16, "mode16");

        public static Label<Mode> Mode32 => Labels.define(Mode.Mode32, "mode32");

        public static Label<Mode> Mode64 => Labels.define(Mode.Mode64, "mode64");

        public static Label<Mode> Not64 => Labels.define(Mode.Not64, "not64");
    }

}