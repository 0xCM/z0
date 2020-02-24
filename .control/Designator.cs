//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using D = Z0.Designators;

    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Control : AssemblyResolution<Control>
    {
        const AssemblyId Identity = AssemblyId.Control;

        public override AssemblyId Id
            => Identity;
            
        public override IEnumerable<IAssemblyResolution> Designates
            => items<IAssemblyResolution>(            
            
            D.Root.Resolution,
            
            D.Nats.Resolution,
            D.NatsTest.Resolution,            
                        
            D.CoreFunc.Resolution, 
            D.CoreFuncTest.Resolution, 
            
            D.Data.Resolution,
            
            D.GMath.Resolution,
            D.GMathTest.Resolution,

            D.Matrix.Resolution,

            D.BitCore.Resolution,
            D.BitCoreTest.Resolution,

            D.BitVectors.Resolution,
            D.BitVectorTest.Resolution,

            D.Intrinsics.Resolution,
            D.IntrinsicsTest.Resolution,            

            D.RngCore.Resolution,

            D.BitGrids.Resolution,
            D.BitGridsTest.Resolution,

            D.AsmCore.Resolution,
            D.AsmCoreTest.Resolution,

            D.MklApi.Resolution,
            D.MklApiTest.Resolution,

            D.Machines.Resolution,
            D.MachineTest.Resolution,

            D.Logix.Resolution,
            D.LogixTest.Resolution,

            D.LibM.Resolution,            
            D.LibMTest.Resolution

            );               
   }
}