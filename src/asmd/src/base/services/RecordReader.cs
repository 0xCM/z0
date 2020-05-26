//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;   
    using static Memories;
    
    public readonly struct RecordReader : IRecordReader
    {
        public R[] Read<F,R,M>(M m)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IDataModel
        {

            return default;
        }

        public R[] Read<F,R,M,D>(M m, D d)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IDataModel
            where D : unmanaged, Enum

        {

            return default;
        }
    }
}