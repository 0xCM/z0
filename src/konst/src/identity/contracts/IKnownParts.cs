//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IKnownParts
    {
        IPart[] Known {get;}

        FilePath[] ComponentPaths {get;}

        FolderPath SearchLocation {get;}

        PartDescription[] Descriptions {get;}        
    }
}