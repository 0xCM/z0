//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface IMethodData
    {
        IMethodHelpers Helpers { get; }

        ulong MethodDesc { get; }
        
        int Token { get; }
        
        MethodCompilationType CompilationType { get; }
        
        ulong HotStart { get; }
        
        uint HotSize { get; }
        
        ulong ColdStart { get; }
        
        uint ColdSize { get; }
    }
}