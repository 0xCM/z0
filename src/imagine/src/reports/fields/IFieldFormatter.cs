//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IFieldFormatter<F> : ITextual
        where F : unmanaged, Enum
    {
        void EmitEol();        
    }
}