//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEmissionWorkflow : IAppEventSink
    {
        IAppContext Context {get;}
        
        FolderPath TargetDir {get;}

        AppMsgColor StartFlair 
            => AppMsgColor.Blue;

        AppMsgColor EndFlair 
            => AppMsgColor.Cyan;        


        FilePath TargetPath(PartId part, EmissionDataType kind)
            => TargetDir + FileName.Define(part.Format(), kind.Ext());

        FilePath PartPath(IPart part)
            => part.PartPath();

        IPartReader Reader(FilePath src)
            => PartReader.open(src);
    }
}