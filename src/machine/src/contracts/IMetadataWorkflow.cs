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
}