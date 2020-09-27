//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;

    public interface IModuleHelpers
    {
        ITypeFactory Factory { get; }
    
        IDataReader DataReader { get; }

        MetadataImport? GetMetadataImport(ClrModule module);
    
        IReadOnlyList<(ulong, int)> GetSortedTypeDefMap(ClrModule module);
    
        IReadOnlyList<(ulong, int)> GetSortedTypeRefMap(ClrModule module);
    
        ClrType? TryGetType(ulong mt);
    
        string? GetTypeName(ulong mt);
    }
}