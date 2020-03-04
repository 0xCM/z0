//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppService<C> : IService, IContextual<C>
        where C : IContext
    {
        
    }

    public interface IAppService : IAppService<IContext>
    {

    }     
}