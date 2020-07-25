//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;

    public readonly partial struct MdR
    {        
        [Flags]
        public enum DllCharacteristics : ushort
        {
            ProcessInit = (ushort)1,
            
            ProcessTerm = (ushort)2,
            
            ThreadInit = (ushort)4,
            
            ThreadTerm = (ushort)8,
            
            HighEntropyVirtualAddressSpace = (ushort)32,
            
            DynamicBase = (ushort)64,
            
            NxCompatible = (ushort)256,
            
            NoIsolation = (ushort)512,
            
            NoSeh = (ushort)1024,
            
            NoBind = (ushort)2048,
            
            AppContainer = (ushort)4096,
            
            WdmDriver = (ushort)8192,
            
            TerminalServerAware = (ushort)32768,
        }
    }
}