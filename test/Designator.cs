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
            typeof(ITypeNat).Assembly,
            D.NatTest.Assembly,
            
            D.CoreData.Assembly,
            
            D.CoreFunc.Assembly, 
            D.CoreFuncTest.Assembly, 
            
            D.CpuFunc.Assembly,
            D.CpuTest.Assembly,

            D.Intrinsics.Assembly,
            D.IntrinsicsTest.Assembly,

            D.PrimalMath.Assembly,
            D.PrimalMathTest.Assembly,

            D.MklApi.Assembly,
            D.MklTest.Assembly,

            D.LinearOps.Assembly,
            D.LinearTest.Assembly,
            D.Matrix.Assembly,

            D.Machines.Assembly,
            D.MachineTest.Assembly,

            D.Bits.Assembly,
            D.BitTest.Assembly,

            D.Rng.Assembly,

            D.LibM.Assembly,            
            D.LibMTest.Assembly,

            D.StatDist.Assembly,

            D.RevealLib.Assembly,
            D.RevealApp.Assembly
            );
    }


}