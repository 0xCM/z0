//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFormatProvider<T> 
    {
        IFormatter<T> Formatter {get;}
    }    
}