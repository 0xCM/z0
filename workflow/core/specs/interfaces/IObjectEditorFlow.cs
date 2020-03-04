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

    public interface IObjectEditorFlow<T> : IObjectFlow<T>
        where T : class
    {
        IEnumerable<T>  Flow(IObjectEditorPipe<T> pipe);
    }

    public interface IObjectEditorFlow<P,T> : IObjectEditorFlow<T>
        where T : class
        where P : IObjectEditorPipe<T>
    {

        IEnumerable<T>  Flow(P pipe);

        IEnumerable<T>  IObjectEditorFlow<T>.Flow(IObjectEditorPipe<T> pipe)
            => Flow((P)pipe);
    }
}