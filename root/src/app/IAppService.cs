//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppService : IService<IAppContext>
    {
         
    }     


    public interface IAppServiceAlloction : IAppService, IServiceAllocation<IAppContext>
    {

    }
}