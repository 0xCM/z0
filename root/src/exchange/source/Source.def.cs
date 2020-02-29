//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public delegate Option<T> SourceEmitter<T>();

    public interface ISource
    {
        
    }

    public interface ISource<T> : ISource
    {
        /// <summary>
        /// Emits the next source value, if any
        /// </summary>
        Option<T> Next();
    }
}