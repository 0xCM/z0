//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    public interface IPointSource<T> : IRandomSource
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source
        /// </summary>
        T Next();    
    }

}