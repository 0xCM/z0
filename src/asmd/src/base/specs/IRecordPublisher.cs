//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IRecordPublisher
    {
        void Publish<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IDataModel
            where R : IRecord
            where F : unmanaged, Enum;
    }    
}