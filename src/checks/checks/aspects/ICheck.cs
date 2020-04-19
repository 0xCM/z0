//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public readonly struct Check : ICheck
    {                    

    }    

    public interface ICheck : 
        IChecker<Check>, 
        ICheckLengths, 
        ICheckPrimal, 
        ICheckPrimalSeq, 
        ICheckClose, 
        ICheckFileSystem,
        ICheckInvariant,
        ICheckEqual,
        ICheckSets,
        ICheckNull,
        ICheckVectors
    {
        
    }
}