//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
 
    partial struct MsD
    {                
        public sealed class DacLibrary
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            private delegate int DllMain(IntPtr instance, int reason, IntPtr reserved);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            private delegate int PAL_Initialize();

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            private delegate int CreateDacInstance(in Guid riid, IntPtr dacDataInterface,out IntPtr ppObj);
        }        
    }
}