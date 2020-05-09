//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct SemanticRender 
    {
        public string RenderAspects<T>(object src)
            where T : class
                => Aspects.From<T>(src).Format();        
        
    }
}