//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies format configurations
    /// </summary>
    public interface IFormatConfig
    {
        
    }

    /// <summary>
    /// Reifies a meaningless implementation of IFormatConfig
    /// </summary>
    readonly struct DefautFormatConfig : IFormatConfig {}
}