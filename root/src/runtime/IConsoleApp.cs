//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public interface IConsoleApp : IAssemblyComposition, IContext
    {
        void RunApp(params string[] args);                
    }
}