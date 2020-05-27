//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecordReader
    {
        R[] Read<F,R,M>(M m)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IDataModel;

        R[] Read<F,R,M,D>(M m, D d)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IDataModel
            where D : unmanaged, Enum;
    }
}