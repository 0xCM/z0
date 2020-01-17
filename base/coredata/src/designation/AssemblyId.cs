//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public enum AssemblyId : ulong
    {
        None = 0,
        
        TypeNats,

        CoreData,

        CoreFunc,

        GMath,

        Intrinsics,

        BitCore,

        BitVectors,

        BitGrids,

        Logix,

        Polyrand,
    }



}