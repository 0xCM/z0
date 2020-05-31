//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using static Seed;

    public interface IMachineIndexBuilder
    {
        int Include(params UriCode[] src);   

        MachineIndex Freeze();
    }
}