//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface IFieldFormatter<F> : ITextual
        where F : unmanaged, Enum
    {
        void EmitEol();        
    }
}