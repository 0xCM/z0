//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    /// <summary>
    /// Characterizes an extraction service with unit of work the collection of operations implemented by all hosts/services
    /// 
    /// </summary>
    public interface IAsmAssemblyExtractor : IAsmOpExtractor<AssemblyId>
    {

    }
}