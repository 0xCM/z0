//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IRecordSink<R> : ISink<R>
        where R : ITabular
    {
        
    }
}