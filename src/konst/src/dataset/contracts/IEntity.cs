//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    
    public interface IEntity<T> : ITextual, INullary<T>, IEquatable<T>
        where T : struct
    {
        
    }

}