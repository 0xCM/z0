//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IZed
    {
        
    }

    public interface IZed<Z> : IZed
        where Z : INullary<Z>, new()
    {
        
    }
}