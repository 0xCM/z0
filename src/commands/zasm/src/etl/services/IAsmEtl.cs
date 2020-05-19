//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using Asm.Data;

    using static Seed;
    using static AsmDataModels;

    public interface IAsmEtl : IService, IAsmArchiveConfig
    {
        void Publish();

    }

}
