//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;   
    using static Memories;

    public interface IAsmDataReader
    {
        R[] Read<F,R,M>(M m)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IAsmDataModel;

        R[] Read<F,R,M,D>(M m, D d)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IAsmDataModel
            where D : unmanaged, Enum;

    }
    
    public readonly struct AsmDataReader : IAsmDataReader, IAsmArchiveConfig
    {
        public R[] Read<F,R,M>(M m)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IAsmDataModel
        {

            return default;
        }

        public R[] Read<F,R,M,D>(M m, D d)
            where F : unmanaged, Enum
            where R : IRecord
            where M : IAsmDataModel
            where D : unmanaged, Enum

        {

            return default;
        }

    }

}