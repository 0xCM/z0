//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    public interface IBaseHexFormatter : IBaseFormatter
    {
        
    }
    
    public interface IBaseHexFormatter<T> : IBaseHexFormatter
        where T : struct
    {
        string Format(T src, string config = null);

        string IBaseFormatter.Format(object src, string config)
            => Format((T)src,config);        
    }

    interface IBaseHexFormatter<F,T> : IBaseHexFormatter<T>
        where F : struct, IBaseHexFormatter<F,T>
        where T : struct
    {
        
    }    
}