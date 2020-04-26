//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        

    public readonly struct TestDynamic : ITestDynamic
    {   
        [MethodImpl(Inline)]
        public static ITestDynamic Create(IPolyrand random)        
            => new TestDynamic(random);

        public IPolyrand Random {get;}
                
        [MethodImpl(Inline)]
        public TestDynamic(IPolyrand random)
        {
            Random = random;
        }        
    }

    public interface ITestDynamic :  ITestDynamicBinary, ITestDynamicUnary, ITestDynamicNumeric, ICheckFixedDynamic
    {       
        
    }
}