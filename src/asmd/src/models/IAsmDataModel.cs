//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    public interface IAsmDataModel
    {   
        string Name {get;}
    }

    public interface IAsmDataModel<M> : IAsmDataModel
        where M : IAsmDataModel<M>, new()
    {
        string IAsmDataModel.Name => typeof(M).Name;
    }

    public interface IAsmDataModel<M,D> : IAsmDataModel<M>
        where D : unmanaged, Enum
        where M : IAsmDataModel<M,D>, new()
    {
        D Discriminator {get;}        
    }
}