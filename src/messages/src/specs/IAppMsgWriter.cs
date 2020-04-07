//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppMsgWriter : IServiceAllocation
    {
        void Write<F>(F formattable)
            where F : ICustomFormattable;  

        void Write<F>(F[] formattables)
            where F : ICustomFormattable;  
    }
}