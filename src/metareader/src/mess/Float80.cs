//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;
        
    /// <summary>
    /// Float in X86-specific windows thread context.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Float80
    {
        [FieldOffset(0x0)]
        public ulong Mantissa;

        [FieldOffset(0x8)]
        public ushort Exponent;
    }            
}