//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct TestOperatorMatch : ITestOperatorMatch
    {   
        [MethodImpl(Inline)]
        public static ITestDynamic Create(IPolyrand random)        
            => new TestDynamic(random);

        public IPolyrand Random {get;}
                
        [MethodImpl(Inline)]
        public TestOperatorMatch(IPolyrand random)
            => Random = random;
    }

    public interface ITestOperatorMatch : ITestFixedMatch, ITestNumericMatch
    {
        
    }    
}