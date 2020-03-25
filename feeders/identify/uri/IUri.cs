//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IUri
    {
        
    }
    
    public interface IUri<T> : IUri, IIdentifiedTarget<T>, IParser<T>
        where T : IUri<T>, new()
    {
        
    }
}