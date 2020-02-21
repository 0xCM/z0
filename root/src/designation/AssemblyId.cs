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
    using static Pow2;

    /// <summary>
    /// Defines identifiers for known system assemblies
    /// </summary>
    public enum AssemblyId : ulong
    {
        None = 0,
        
        Empty = T00,
        
        Root = T01,

        TypeNats = T02,

        DataCore = T03,

        CoreFunc = T04,

        GMath = T05,

        Intrinsics = T07,

        BitCore = T08,

        BitFields = T09,
        
        BitVectors = T10,

        BitGrids = T11,

        Logix = T12,

        Polyrand = T13,

        AsmCore = T14,

        Data = T15,

        LibM = T16,

        Matrix = T17,

        LinearOps = T18,

        Machines = T19,

        RngCore = T20,

        MathObjects = T21,
        
        MklApi = T22,

        FastOps = T23,

        Validation = T24,

        Control = T63,

    }

    partial class RootKindExtensions
    {

        [MethodImpl(Inline)]
        public static string Format(this AssemblyId id)
            => id.ToString().ToLower();
    }    
}