//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface IModuleData
    {
        IModuleHelpers Helpers { get; }

        ulong Address { get; }
    
        bool IsPEFile { get; }
    
        ulong PEImageBase { get; }
    
        ulong ILImageBase { get; }
    
        bool IsFileLayout { get; }
    
        ulong Size { get; }
    
        ulong MetadataStart { get; }
    
        string? Name { get; }
    
        string? AssemblyName { get; }
    
        ulong MetadataLength { get; }
    
        bool IsReflection { get; }
    
        ulong AssemblyAddress { get; }
    }
}