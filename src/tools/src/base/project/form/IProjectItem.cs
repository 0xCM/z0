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

    public interface IProjectItem : IProjectElement
    {
        
    }
    
    public interface IProjectItem<F> : IProjectItem, IProjectElement<F>
        where F : struct, IProjectItem<F>
    {
        
    }
}