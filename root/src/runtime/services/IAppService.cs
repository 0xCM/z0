//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppService : IService, IContextual
    {
        
    }     

    public interface IAppService<C> : IService, IContextual<C>
        where C : IContext
    {
        
    }


    public interface IAppServiceAlloction : IAppService, IServiceAllocation
    {

    }

    public interface IAppServiceAlloction<C> : IServiceAllocation, IAppService<C>
        where C : IContext
    {
        
    }

}