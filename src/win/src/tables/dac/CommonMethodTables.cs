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
    public struct CommonMethodTables
    {
        public ClrDataAddress ArrayMethodTable;
        
        public ClrDataAddress StringMethodTable;
        
        public ClrDataAddress ObjectMethodTable;
        
        public ClrDataAddress ExceptionMethodTable;
        
        public ClrDataAddress FreeMethodTable;
    }
}