//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IUnitTest : ITestContext 
    {
        void SetMode(bool diagnostic);
    }    
}