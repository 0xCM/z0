//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines identifiers for known system assemblies
    /// </summary>
    public enum AssemblyId : ulong
    {
        None = 0,
        
        Root = 1,

        TypeNats = 2,

        CoreData = 4,

        CoreFunc = 8,

        GMath = 16,

        Intrinsics = 32,

        BitCore,

        BitVectors,

        BitGrids,

        Logix,

        Polyrand,

        AsmCore,

        EmbeddedData,

        LibM,

        Matrix,

        LinearOps,

        Machines,

        RngCore,

        MathObjects,
        
        MklApi
    }

    
     
}