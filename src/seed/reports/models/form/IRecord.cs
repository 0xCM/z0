//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecord : ITabular, ISequential
    {

    }


    public interface IRecord<R> : IRecord, ITabular<R>
        where R : IRecord
    {


    }

    public interface IRecord<F,R> : IRecord<R>, ITabular<F,R>, ITextual
        where F : unmanaged, Enum
        where R : IRecord
    {
        
        
    }
}