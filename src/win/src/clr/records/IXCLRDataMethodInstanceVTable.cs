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
 
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct IXCLRDataMethodInstanceVTable
    {
        public readonly IntPtr GetTypeInstance;
        
        public readonly IntPtr GetDefinition;
        
        public readonly IntPtr GetTokenAndScope;
        
        public readonly IntPtr GetName;
        
        public readonly IntPtr GetFlags;
        
        public readonly IntPtr IsSameObject;
        
        public readonly IntPtr GetEnCVersion;
        
        public readonly IntPtr GetNumTypeArguments;
        
        public readonly IntPtr GetTypeArgumentByIndex;
        
        // (ulong address, uint offsetsLen, out uint offsetsNeeded, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] ilOffsets);
        public readonly IntPtr GetILOffsetsByAddress; 
        
        // (uint ilOffset, uint rangesLen, out uint rangesNeeded, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] addressRanges);
        public readonly IntPtr GetAddressRangesByILOffset;
        
        public readonly IntPtr GetILAddressMap;
        
        public readonly IntPtr StartEnumExtents;
        
        public readonly IntPtr EnumExtent;
        
        public readonly IntPtr EndEnumExtents;
        
        public readonly IntPtr Request;
        
        public readonly IntPtr GetRepresentativeEntryAddress;
    }
}