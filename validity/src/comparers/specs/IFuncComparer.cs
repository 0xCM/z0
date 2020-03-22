//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IFuncComparer<C> : IAppService<C>
        where C : IComparisonContext
    {
    }

    public interface IFuncComparer : IFuncComparer<IComparisonContext>
    {
        
    }
}