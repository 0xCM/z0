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
    public readonly struct COMInterfacePointerData
    {
        public readonly ClrDataAddress MethodTable;
        public readonly ClrDataAddress InterfacePointer;
        public readonly ClrDataAddress ComContext;
    }    
}