//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface ITypeHelpers
    {
        IDataReader DataReader { get; }

        ITypeFactory Factory { get; }

        IClrObjectHelpers ClrObjectHelpers { get; }

        bool GetTypeName(ulong mt, out string? name);
        ulong GetLoaderAllocatorHandle(ulong mt);

        // TODO: Should not expose this:
        IObjectData GetObjectData(ulong objRef);
    }
}