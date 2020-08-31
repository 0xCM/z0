//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// A trait that attaches a width to a realization
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    public interface TWidth<W> 
        where W : struct, TDataWidth<W>
    {
        DataWidth Width 
            => Widths.data<W>();
    }
}