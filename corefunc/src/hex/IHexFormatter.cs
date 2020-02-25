//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexFormatter
    {
        string FormatItem(object item);

        string FormatItem(object item, string format);
    }


    public interface IHexFormatter<T> : IHexFormatter, ISpanFormatter<T,HexSeqFormat,HexFormat>
        where T : struct
         
    {        
        
    }    
}