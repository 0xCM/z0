//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IChecks : 
        TCheckLengths, 
        TCheckPrimal, 
        ICheckPrimalSeq, 
        TCheckClose, 
        TCheckFileSystem,
        TCheckInvariant,
        TCheckSets,
        TCheckNull        
    {

    }

    public readonly struct Checks : IChecks
    {
        public static IChecks Checker => default(Checks);
    }
}