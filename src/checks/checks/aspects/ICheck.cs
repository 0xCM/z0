//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public interface ICheck : 
        IChecker<Check>, 
        ICheckLengths, 
        ICheckPrimal, 
        ICheckPrimalSeq, 
        ICheckApproximate, 
        ICheckFileSystem,
        ICheckInvariant,
        ICheckEqual,
        ICheckVectorEquality,
        ICheckSets,
        ICheckNull
    {
        
    }

    public readonly struct Check : ICheck
    {                    

    }    
}