//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static Seed;

    public interface IDataEntity : ITextual, INullaryKnown
    {
        
    }

    public interface IDataEntity<T> : IDataEntity, INullary<T>, IEquatable<T>
        where T : struct
    {
        
    }

}