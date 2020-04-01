//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;


    public interface ISystemHexFormatter : ISystemFormatter
    {
        
    }
    
    public interface ISystemHexFormatter<T> : ISystemHexFormatter
        where T : struct
    {
        string Format(T src, string config = null);

        string ISystemFormatter.Format(object src, string config)
            => Format((T)src,config);        
    }

    interface ISystemHexFormatter<F,T> : ISystemHexFormatter<T>
        where F : struct, ISystemHexFormatter<F,T>
        where T : struct
    {
        
    }    
}