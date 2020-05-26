//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static Seed;

    public interface IEntity : ITextual, INullaryKnown
    {
        
    }

    public interface IEntity<T> : IEntity, INullary<T>, IEquatable<T>
        where T : struct
    {
        
    }

}