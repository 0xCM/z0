//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    public interface IAsmReport : IReport
    {

    }

    public interface IAsmReport<R> : IAsmReport,  IReport<R>
        where R : IRecord<R>
    {
        
    }
}