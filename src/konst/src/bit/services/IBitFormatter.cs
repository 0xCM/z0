//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitFormatter<T> : IFormatter<BitFormatConfig,T>
        where T : struct
    {
    }    
}