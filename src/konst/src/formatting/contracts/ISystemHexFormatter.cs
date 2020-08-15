//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISystemHexFormatter<T> : ISystemFormatter
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