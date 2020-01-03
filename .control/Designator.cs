//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    public sealed class Controller : AssemblyDesignator<Controller>
    {
        public override IEnumerable<Assembly> Dependencies 
            => items(
            typeof(ITypeNat).Assembly,
            D.NatTest.Assembly,            
            D.CoreData.Assembly,            
            D.CoreFunc.Assembly, 
            D.CoreFuncTest.Assembly, 
            
            D.GMath.Assembly,
            D.GMathTest.Assembly,

            D.Matrix.Assembly,

            D.BitCore.Assembly,
            D.BitCoreTest.Assembly,

            D.Intrinsics.Assembly,
            D.IntrinsicsTest.Assembly,            

            D.RngCore.Assembly,

            D.Bits.Assembly,
            D.BitTest.Assembly,

            D.CpuFunc.Assembly,
            D.CpuTest.Assembly,

            D.MklApi.Assembly,
            D.MklTest.Assembly,

            D.LinearOps.Assembly,
            D.LinearTest.Assembly,

            D.Machines.Assembly,
            D.MachineTest.Assembly,

            D.LibM.Assembly,            
            D.LibMTest.Assembly,

            D.StatDist.Assembly,

            D.RevealLib.Assembly,
            D.RevealApp.Assembly
            );
    }
}