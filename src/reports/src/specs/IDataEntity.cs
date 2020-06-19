//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IDataEntity : ITextual, INullity
    {
        
    }

    public interface IDataEntity<T> : IDataEntity, INullary<T>, IEquatable<T>
        where T : struct
    {
        
    }

}