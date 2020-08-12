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

    [Table, StructLayout(LayoutKind.Sequential)]
    public struct AssemblyData
    {
        public ClrDataAddress Address;
        
        public ClrDataAddress ClassLoader;
        
        public ClrDataAddress ParentDomain;
        
        public ClrDataAddress AppDomain;
        
        public ClrDataAddress AssemblySecurityDescriptor;
        
        public int Dynamic;
        
        public int ModuleCount;
        
        public uint LoadContext;
        
        public int IsDomainNeutral;
        
        public uint LocationFlags;
    }
}