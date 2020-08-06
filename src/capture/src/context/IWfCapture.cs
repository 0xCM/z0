//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public interface IWfCapture : IContext
    {
        IAsmContext AsmContext {get;}

        IAppContext ContextRoot 
            => AsmContext.ContextRoot;
        
        IAppPaths AppPaths 
            => ContextRoot.AppPaths;
    }
}