//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>    
    /// Defines a test service which is, by definition, a contextual service of test context kind
    /// </summary>
    public interface ITestService : IService<ITestContext>, IPolyrandProvider, TCheckOptions, TTestCaseIdentity, TClocked
    {
        IPolyrand IPolyrandProvider.Random => Context.Random;   

        void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Context.Deposit(AppMsg.Error(e, caller,file,line));        
    }
}