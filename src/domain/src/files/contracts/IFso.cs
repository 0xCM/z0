//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static FileSystem;

    public interface IFso : ITextual
    {
        PathPart Name {get;}    

        string ITextual.Format() 
            => Name.Format();
    }

    public interface IFso<F> : IFso 
        where F : struct, IFso<F>
    {
        
    }
}