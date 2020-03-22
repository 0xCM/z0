//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IUri
    {
        
    }
    
    public interface IUri<T> : IUri, IIdentified<T>, IParser<T>
        where T : IUri<T>, new()
    {
        
    }
}