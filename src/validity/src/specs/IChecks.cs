//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public interface IChecks : 
        ICheckLengths, 
        ICheckPrimal, 
        ICheckPrimalSeq, 
        ICheckClose, 
        ICheckFileSystem,
        ICheckInvariant,
        ICheckSets,
        ICheckNull        

    {

    }

    public readonly struct Checks : IChecks
    {
        public static IChecks Checker => default(Checks);
    }
}