//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    public interface IWfCapture : IContext
    {
        IAsmContext AsmContext {get;}

        IAppContext ContextRoot 
            => AsmContext.ContextRoot;
        
        IAppPaths AppPaths 
            => ContextRoot.AppPaths;
    }
}