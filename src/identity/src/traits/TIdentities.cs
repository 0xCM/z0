//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TIdentities
    {
        IMultiDiviner Diviner 
            => MultiDiviner.Service;

        ApiCollector Collector 
            => ApiCollector.Service;

        MemberLocator Locator 
            => MemberLocator.Service;
    }
}