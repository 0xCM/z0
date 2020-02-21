//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public interface IObjectEditorPipe<T> : IObjectPipe<T>
        where T : class
    {
        T Flow(T src);            

        object IPipe.Flow(object src)
            => Flow(Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }

}