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
    using System.Threading.Tasks;

    using static zfunc;

    public interface IValueEditorFlow<T> : IValueFlow
        where T : struct
    {
        ref T Flow(ref T src);                
    }

    public interface IValueEditorFlow<P,T> : IValueEditorFlow<T>, IValueFlow<P,T>
        where T : struct
        where P : IValueEditorPipe<T>
    {
         
        T[] Flow(T[] src, P dst)
        {
            for(var i=0; i<src.Length; i++)
                Flow(ref src[i]);
            return src;
        }        
    }
}