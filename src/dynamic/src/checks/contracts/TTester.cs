//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ITestRandom : TTester, IPolyrandProvider
    {


    }        
        
    public interface TTestChecker : TTester, TTestResultSink
    {
        
    }

    public interface TTester : TClocked, TCheckOptions, TTestCaseIdentity, TCheckError
    {        
        
    }       
}