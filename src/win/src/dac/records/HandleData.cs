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
    public readonly struct HandleData
    {
        public readonly ClrDataAddress AppDomain;

        public readonly ClrDataAddress Handle;

        public readonly ClrDataAddress Secondary;

        public readonly uint Type;

        public readonly uint StrongReference;

        // For RefCounted Handles
        public readonly uint RefCount;

        public readonly uint JupiterRefCount;

        public readonly uint IsPegged;
    }    
}