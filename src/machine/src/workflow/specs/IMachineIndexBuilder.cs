//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    public interface IMachineIndexBuilder
    {
        int Include(params UriCode[] src);   

        MachineIndex Freeze();
    }
}