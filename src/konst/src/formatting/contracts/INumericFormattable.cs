//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INumericFormattable<T> 
        where T : unmanaged
    {
        INumericFormatter<T> Formatter {get;}
    }
}