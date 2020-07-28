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
    public readonly struct CommonMethodTables
    {
        public readonly ClrDataAddress ArrayMethodTable;
        
        public readonly ClrDataAddress StringMethodTable;
        
        public readonly ClrDataAddress ObjectMethodTable;
        
        public readonly ClrDataAddress ExceptionMethodTable;
        
        public readonly ClrDataAddress FreeMethodTable;
    }
}