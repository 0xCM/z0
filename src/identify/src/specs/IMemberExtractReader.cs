//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Defines service contract to support reading text-formatted encoded x86 asm data
    /// </summary>
    public interface IMemberExtractReader : IService
    {
        ExtractedMember[] Read(FilePath src);       
    }


}