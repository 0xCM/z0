//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;
    using static z;

    public struct CpuWorkerSettings
    {
        public uint Id;

        public uint Core;

        public Duration Frequency;
    }
}