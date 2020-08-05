//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AppDomainStoreData
    {
        public readonly ClrDataAddress SharedDomain;

        public readonly ClrDataAddress SystemDomain;

        public readonly int AppDomainCount;
    }
}