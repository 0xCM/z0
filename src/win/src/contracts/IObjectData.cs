//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    public interface IObjectData
    {
        ulong DataPointer { get; }

        ulong ElementTypeHandle { get; }

        ClrTypeCode ElementType { get; }

        ulong RCW { get; }

        ulong CCW { get; }
    }
}