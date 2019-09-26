//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using D = Z0.Designators;

    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class TestController : AssemblyDesignator<TestController>
    {
        public override IEnumerable<Assembly> Dependencies 
            => items(
            typeof(Bit).Assembly,
            typeof(ITypeNat).Assembly,
            D.NatTest.Assembly,
            D.CoreFunc.Assembly, 
            D.CoreFuncTest.Assembly, 
            D.CpuData.Assembly,
            D.CpuFunc.Assembly,
            D.CpuTest.Assembly,
            D.Intrinsics.Assembly,
            D.PrimalMath.Assembly,
            D.PrimalMathTest.Assembly,
            D.Bits.Assembly,
            D.BitTest.Assembly,
            D.Circuits.Assembly,
            D.CircuitTest.Assembly,
            D.Rng.Assembly
            );
    }


}