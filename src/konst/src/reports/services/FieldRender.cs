//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    
    public readonly struct FieldRender<F> : TFieldRender<F>
        where F : unmanaged, Enum
    {
        public static TFieldRender<F> Service
            => default(FieldRender<F>);
    }
}