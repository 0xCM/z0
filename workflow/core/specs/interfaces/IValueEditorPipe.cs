//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public interface IValueEditorPipe<T> : IValuePipe<T>
        where T : struct
    {
        ref T Flow(ref T src);            

        object IPipe.Flow(object src)
            => Flow(ref Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }
}