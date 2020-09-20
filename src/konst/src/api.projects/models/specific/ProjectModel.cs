//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public readonly partial struct ProjectModel
    {        
        public readonly struct ResProject
        {
            public const string OutputType = "Library";
            
            public const string TargetFramework = "TargetFramework";   
        }
    }
}