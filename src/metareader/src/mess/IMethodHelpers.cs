//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    public interface IMethodHelpers
    {
        IDataReader DataReader { get; }

        bool GetSignature(ulong methodDesc, out string? signature);
        
        ImmutableArray<ILToNativeMap> GetILMap(ulong nativeCode, in HotColdRegions hotColdInfo);
        
        ulong GetILForModule(ulong address, uint rva);
    }
}