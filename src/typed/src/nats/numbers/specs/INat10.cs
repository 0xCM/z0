//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat10<F> : INatNumber<N10>
        where F : unmanaged, INat10<F>
    {
        
    }

}