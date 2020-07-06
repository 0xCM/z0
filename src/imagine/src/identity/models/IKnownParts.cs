//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IKnownParts
    {
        IEnumerable<IPart> Known {get;}

        FilePath[] ComponentPaths {get;}

        FolderPath SearchLocation {get;}

        PartDescription[] Descriptions {get;}        
    }
}