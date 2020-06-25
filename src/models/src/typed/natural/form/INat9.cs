//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INat9<F> : INatNumber<N9>
        where F : unmanaged, INat9<F>
    {
        
    }

}