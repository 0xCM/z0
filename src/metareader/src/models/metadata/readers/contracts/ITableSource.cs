//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableSource : ISourceFacets
    {
        
    }
    
    public interface ITableSource<T> : ITableSource    
    {
        T RowSource {get;}    
    }

}