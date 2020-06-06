//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMetadataRecord : ITextual
    {
        string Format(char delimiter);   
    }
    
    public interface IMetadataRecord<F> : IMetadataRecord
        where F : struct, IMetadataRecord<F>
    {
        
    }
    
    public interface IMetadataRecord<F,K> : IMetadataRecord<F>
        where F : struct, IMetadataRecord<F,K>
        where K : unmanaged, IMetadataRecordSpec
    {
        K Kind  => default;
    }

    public interface IMetadataRecord<F,K,I> : IMetadataRecord<F,K>
        where F : struct, IMetadataRecord<F,K,I>
        where I : unmanaged, Enum
        where K : unmanaged, IMetadataRecordSpec
    {
        
    }    
}