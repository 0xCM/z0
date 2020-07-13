//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMetadataEmitters : IMetadataWorkflow
    {        
        PeDataEmitter PeData 
            => new PeDataEmitter(this);

        CilDataEmitter CilData
            => new CilDataEmitter(this);

        ConstantDataEmitter ConstantData
            => new ConstantDataEmitter(this);

        StringDataEmitter StringData
            => new StringDataEmitter(this);            

        BlobDataEmitter BlobData
            => new BlobDataEmitter(this);                        
    }
}