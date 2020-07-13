//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMetadataWorkflow : IEmissionWorkflow
    {
        FilePath TargetPath(PartId part, MetadataEmissionKind kind)
            => TargetDir + FileName.Define(part.Format(), kind.Ext());

        FilePath PartPath(IPart part)
            => part.PartPath();
        
        PartRecordSpecs DataTypes
            => default;

        IPartReader Reader(FilePath src)
            => PartReader.open(src);

    }        

    public interface IMetadataEmitter : IMetadataWorkflow
    {
        
        PeDataEmitter PeData 
            => new PeDataEmitter(this);

        CilDataEmitter CilData
            => new CilDataEmitter(this);

        ConstantDataEmitter ConstantData
            => new ConstantDataEmitter(this);

        StringDataEmitter StringData
            => new StringDataEmitter(this);            
    }
}