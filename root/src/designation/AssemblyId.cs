//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static RootShare;

    /// <summary>
    /// Defines identifiers for known system assemblies
    /// </summary>
    public enum AssemblyId : ulong
    {
        None = 0,
        
        Empty = 1,
        
        Root = 2,

        TypeNats = 4,

        DataCore = 8,

        CoreFunc = 16,

        GMath = 32,

        Intrinsics = 64,

        BitCore,

        BitVectors,

        BitGrids,

        Logix,

        Polyrand,

        AsmCore,

        Data,

        LibM,

        Matrix,

        LinearOps,

        Machines,

        RngCore,

        MathObjects,
        
        MklApi,

        Control,

        FastOps,

        Validation
    }

    partial class RootKindExtensions
    {

        [MethodImpl(Inline)]
        public static string Format(this AssemblyId id)
            => id.ToString().ToLower();
    }    
}