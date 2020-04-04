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
    /// Defines an aspect that specifies a bit width
    /// </summary>
    public interface IBitWidth
    {
        uint BitWidth {get;}        
    }

}