//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// The basic VTable for an IUnknown interface.
    /// </summary>
    public struct IUnknownVTable
    {
        public IntPtr QueryInterface;
        
        public IntPtr AddRef;
        
        public IntPtr Release;
    }
}