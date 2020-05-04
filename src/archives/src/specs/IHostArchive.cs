//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a host-invariant archive
    /// </summary>
    public interface IHostArchive : IPartArchive
    {
        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri Host {get;}
    }
}