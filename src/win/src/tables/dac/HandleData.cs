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
    public struct HandleData
    {
        public ClrDataAddress AppDomain;

        public ClrDataAddress Handle;

        public ClrDataAddress Secondary;

        public uint Type;

        public uint StrongReference;

        // For RefCounted Handles
        public uint RefCount;

        public uint JupiterRefCount;

        public uint IsPegged;
    }    
}