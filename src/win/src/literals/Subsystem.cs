//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum Subsystem : ushort
    {
        Unknown = (ushort)0,
        
        Native = (ushort)1,
        
        WindowsGui = (ushort)2,
        
        WindowsCui = (ushort)3,
        
        OS2Cui = (ushort)5,
        
        PosixCui = (ushort)7,
        
        NativeWindows = (ushort)8,
        
        WindowsCEGui = (ushort)9,
        
        EfiApplication = (ushort)10,
        
        EfiBootServiceDriver = (ushort)11,
        
        EfiRuntimeDriver = (ushort)12,
        
        EfiRom = (ushort)13,
        
        Xbox = (ushort)14,
        
        WindowsBootApplication = (ushort)16,
    }


}