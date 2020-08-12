//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum SectionCharacteristics : uint
    {
        TypeReg = (uint)0,
        
        TypeDSect = (uint)1,
        
        TypeNoLoad = (uint)2,
        
        TypeGroup = (uint)4,
        
        TypeNoPad = (uint)8,
        
        TypeCopy = (uint)16,
        
        ContainsCode = (uint)32,
        
        ContainsInitializedData = (uint)64,
        
        ContainsUninitializedData = (uint)128,
        
        LinkerOther = (uint)256,
        
        LinkerInfo = (uint)512,
        
        TypeOver = (uint)1024,
        
        LinkerRemove = (uint)2048,
        
        LinkerComdat = (uint)4096,
        
        MemProtected = (uint)16384,
        
        NoDeferSpecExc = (uint)16384,
        
        GPRel = (uint)32768,
        
        MemFardata = (uint)32768,
        
        MemSysheap = (uint)65536,
        
        Mem16Bit = (uint)131072,
        
        MemPurgeable = (uint)131072,
        MemLocked = (uint)262144,
        MemPreload = (uint)524288,
        Align1Bytes = (uint)1048576,
        Align2Bytes = (uint)2097152,
        Align4Bytes = (uint)3145728,
        Align8Bytes = (uint)4194304,
        Align16Bytes = (uint)5242880,
        Align32Bytes = (uint)6291456,
        Align64Bytes = (uint)7340032,
        Align128Bytes = (uint)8388608,
        Align256Bytes = (uint)9437184,
        Align512Bytes = (uint)10485760,
        Align1024Bytes = (uint)11534336,
        Align2048Bytes = (uint)12582912,
        Align4096Bytes = (uint)13631488,
        Align8192Bytes = (uint)14680064,
        AlignMask = (uint)15728640,
        LinkerNRelocOvfl = (uint)16777216,
        MemDiscardable = (uint)33554432,
        MemNotCached = (uint)67108864,
        MemNotPaged = (uint)134217728,
        MemShared = (uint)268435456,
        MemExecute = (uint)536870912,
        MemRead = (uint)1073741824,
        MemWrite = (uint)2147483648,
    }
}