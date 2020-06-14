//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    
    public interface IRecordSink<R> : IService, ISink<R>
        where R : ITabular
    {

        
    }
}