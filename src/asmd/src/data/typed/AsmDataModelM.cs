//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    public readonly struct AsmDataModel<M> : IDataModel<M>
        where M : unmanaged, IDataModel<M>
    {
        
    }

    public readonly struct AsmDataModel<F,R,M,D>
        where F : unmanaged, Enum
        where R : IRecord
        where M : IDataModel
        where D : unmanaged, Enum
    {
        public D Discriminator {get;}                
    }
}