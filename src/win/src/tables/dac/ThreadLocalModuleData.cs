//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ThreadLocalModuleData
    {
        public ClrDataAddress ThreadAddress;

        public ClrDataAddress ModuleIndex;

        public ClrDataAddress ClassData;

        public ClrDataAddress DynamicClassTable;

        public ClrDataAddress GCStaticDataStart;

        public ClrDataAddress NonGCStaticDataStart;
    }
}