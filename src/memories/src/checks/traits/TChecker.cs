//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TChecker : 
        TCheckError, 
        TCheckInvariant, 
        TCheckLengths, 
        TCheckFileSystem, 
        TCheckNull, 
        TCheckOptions, 
        TCheckPrimal,
        TCheckSets
    {
    
    }
}