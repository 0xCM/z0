//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TChecks :
        ICheckLengths,
        ICheckPrimal,
        ICheckPrimalSeq,
        ICheckClose,
        ICheckFiles,
        ICheckInvariant,
        ICheckSets,
        ICheckNull
    {

    }
}