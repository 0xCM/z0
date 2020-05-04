//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes an part-invariant archive
    /// </summary>
    public interface IPartArchive : IService
    {
        /// <summary>
        /// The owning part
        /// </summary>
        PartId Part {get;}
    }
}