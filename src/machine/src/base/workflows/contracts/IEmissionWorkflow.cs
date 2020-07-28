//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEmissionWorkflow : IWorkflow
    {        
        FolderPath TargetDir {get;}

        FilePath TargetPath(PartId part, EmissionDataType kind)
            => TargetDir + FileName.Define(part.Format(), kind.Ext());

        FilePath PartPath(IPart part)
            => part.PartPath();
        
        FolderPath BuildStage
            => Context.AppPaths.LogRoot + FolderName.Define("builds");

        FolderPath PartDatDir
            => BuildStage + FolderName.Define("dat");
    }
}