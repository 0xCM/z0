//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public interface ICheck : IValidator, 
        ICheckLengths, 
        ICheckPrimal, 
        ICheckPrimalSeq, 
        ICheckApproximate, 
        ICheckFileSystem,
        ICheckInvariant,
        ICheckEqual,
        ICheckEnum,
        ICheckVectorEquality,
        ICheckSets,
        ICheckNull
    {
        static ICheck Checker => Claim.Checker;
    }
}