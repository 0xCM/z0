//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Table, StructLayout(LayoutKind.Sequential)]
    public readonly struct AppDomainStoreData
    {
        public readonly ClrDataAddress SharedDomain;

        public readonly ClrDataAddress SystemDomain;

        public readonly int AppDomainCount;
    }
}