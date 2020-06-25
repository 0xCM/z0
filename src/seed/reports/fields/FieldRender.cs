//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IFieldRender<F>
        where F : unmanaged, Enum
    {
        RecordFormatter<F> Formatter => RecordFormatter<F>.Default;        

    }

    public readonly struct FieldRender<F> : IFieldRender<F>
        where F : unmanaged, Enum
    {
        public RecordFormatter<F> Formatter 
            => RecordFormatter<F>.Default;        
    }
}