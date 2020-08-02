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
    public readonly struct CommonMethodTables
    {
        public readonly ClrDataAddress ArrayMethodTable;
        
        public readonly ClrDataAddress StringMethodTable;
        
        public readonly ClrDataAddress ObjectMethodTable;
        
        public readonly ClrDataAddress ExceptionMethodTable;
        
        public readonly ClrDataAddress FreeMethodTable;
    }
}