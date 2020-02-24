//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    public interface IAppService<C> : IService, IContextual<C>
        where C : IContext
    {
        
    }

    public interface IAppService : IAppService<IContext>
    {

    }
     
    public interface IAppService<C,S> : IService, IContextual<C,S>
        where C : IContext<S>
    {
        
    }

}