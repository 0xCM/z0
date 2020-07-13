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
    }
}