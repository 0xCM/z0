//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    using static ClrDataModel;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AssemblyData
    {
        public readonly ClrDataAddress Address;
        public readonly ClrDataAddress ClassLoader;
        public readonly ClrDataAddress ParentDomain;
        public readonly ClrDataAddress AppDomain;
        public readonly ClrDataAddress AssemblySecurityDescriptor;
        public readonly int Dynamic;
        public readonly int ModuleCount;
        public readonly uint LoadContext;
        public readonly int IsDomainNeutral;
        public readonly uint LocationFlags;
    }
}