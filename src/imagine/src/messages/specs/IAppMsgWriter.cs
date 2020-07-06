//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppMsgWriter : IServiceAllocation
    {
        void Write<F>(F formattable)
            where F : ITextual;  

        void Write<F>(F[] formattables)
            where F : ITextual;  
    }
}