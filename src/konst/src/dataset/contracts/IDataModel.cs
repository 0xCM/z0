//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface IDataModel
    {   
        string Name {get;}
    }

    public interface IDataModel<M> : IDataModel
        where M : IDataModel<M>, new()
    {
        string IDataModel.Name 
            => typeof(M).Name;
    }

    public interface IDataModel<M,D> : IDataModel<M>
        where D : unmanaged, Enum
        where M : IDataModel<M,D>, new()
    {
        D Discriminator {get;}        
    }

    public readonly struct DataModel<M> : IDataModel<M>
        where M : unmanaged, IDataModel<M>
    {
        
    }

    public readonly struct DataModel<F,R,M,D>
        where F : unmanaged, Enum
        where R : IRecord
        where M : IDataModel
        where D : unmanaged, Enum
    {
        public D Discriminator {get;}                
    }

}