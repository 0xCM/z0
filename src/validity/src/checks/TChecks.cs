//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TChecks : 
        TCheckLengths, 
        TCheckPrimal, 
        TCheckPrimalSeq, 
        TCheckClose, 
        TCheckFileSystem,
        TCheckInvariant,
        TCheckSets,
        TCheckNull        
    {

    }

    public readonly struct Checks : TChecks
    {
        public static TChecks Checker => default(Checks);
    }
}