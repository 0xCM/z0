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

        IEnumerable<FilePath> ComponentPaths {get;}

        FolderPath SearchLocation {get;}

        IEnumerable<PartDescription> Descriptions {get;}        
    }
}