//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IUri : IIdentified
    {
        
    }
    
    public interface IUri<T> : IUri, IIdentifiedTarget<T>
        where T : IUri<T>, new()
    {
        
    }
}