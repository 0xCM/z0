//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;    

    public interface IConsoleApp : IAssemblyComposition, IRngContext
    {
        void RunApp(params string[] args);   
             
    }

}