//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    public interface ITestDynamic : ITestDynamicBinary, ITestDynamicUnary, ITestDynamicNumeric, ICheckDynamic
    {       
        IDynamicOps Dynamic => TestDynamic.Dynamic;
    }

    readonly struct TestDynamic
    {
        public static IDynamicOps Dynamic => IContext.Default.Dynamic();
    }
}