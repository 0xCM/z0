//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface IDocument
    {

    }
    
    public interface IDocument<F> : IDocument
        where F : unmanaged, Enum
    {

    }

    public interface IDocument<F,T> : IDocument<F>
        where F : unmanaged, Enum
        where T : struct, IDocument<F,T>
    {

    }    
}