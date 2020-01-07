//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Collections.Generic;

    using D = Z0.Designators;

    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Control : AssemblyDesignator<Control>
    {
        public override IEnumerable<IAssemblyDesignator> Designates
            => items<IAssemblyDesignator>(            
            D.NatTest.Designated,            
            D.CoreData.Designated,            
            D.CoreFunc.Designated, 
            D.CoreFuncTest.Designated, 
            
            D.GMath.Designated,
            D.GMathTest.Designated,

            D.Matrix.Designated,

            D.BitCore.Designated,
            D.BitCoreTest.Designated,

            D.BitVectors.Designated,
            D.BitVectorTest.Designated,

            D.Intrinsics.Designated,
            D.IntrinsicsTest.Designated,            

            D.RngCore.Designated,

            D.Bits.Designated,
            D.BitTest.Designated,

            D.CpuFunc.Designated,
            D.CpuTest.Designated,

            D.MklApi.Designated,
            D.MklTest.Designated,

            D.LinearOps.Designated,
            D.LinearTest.Designated,

            D.Machines.Designated,
            D.MachineTest.Designated,

            D.Logix.Designated,
            D.LogixTest.Designated,

            D.LibM.Designated,            
            D.LibMTest.Designated,

            D.StatDist.Designated,

            D.RevealLib.Designated,
            D.RevealApp.Designated
            );                 
   }
}