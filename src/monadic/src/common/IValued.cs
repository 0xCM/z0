//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    public interface IValued<T> : ITextual, INullaryKnown, INullary<T>
        where T : IValued<T>, new()
    {
        
    }
}