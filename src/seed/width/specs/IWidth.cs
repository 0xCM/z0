//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// A trait that attaches a width to a realization
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    public interface IWidth<W> 
        where W : struct, IDataWidth<W>
    {
        DataWidth Width => Widths.data<W>();
    }
}