//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    public interface IArtistryContext : IContext
    {
        IAsmContext AsmContext {get;}
        
        IAppMsgSink AppMsgSink {get;}        
        
        PartId[] Parts {get;}        
    }    
}