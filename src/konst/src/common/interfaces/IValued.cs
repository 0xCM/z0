//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{            
    public interface IValued<T> : ITextual, INullity, INullary<T>
        where T : IValued<T>, new()
    {
        
    }
}