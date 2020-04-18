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
        ICheckCollective, 
        ICheckFileSystem,
        ICheckInvariant,
        ICheckIntrinsic,
        ICheckEquality,
        IEquatableCheck,
        ICheckEnum
    {
        static ICheck Checker => Claim.Checker;
    }
}