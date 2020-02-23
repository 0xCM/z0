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
    public sealed class Control : AssemblyDesignator<Control>
    {
        const AssemblyId Identity = AssemblyId.Control;

        public override AssemblyId Id
            => Identity;
            
        public override IEnumerable<IAssemblyDesignator> Designates
            => items<IAssemblyDesignator>(            
            
            D.Root.Designated,
            
            D.Nats.Designated,
            D.NatsTest.Designated,            
                        
            D.CoreFunc.Designated, 
            D.CoreFuncTest.Designated, 
            
            D.Data.Designated,
            
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

            D.BitGrids.Designated,
            D.BitGridsTest.Designated,

            D.AsmCore.Designated,
            D.AsmCoreTest.Designated,

            D.MklApi.Designated,
            D.MklApiTest.Designated,

            D.Machines.Designated,
            D.MachineTest.Designated,

            D.Logix.Designated,
            D.LogixTest.Designated,

            D.LibM.Designated,            
            D.LibMTest.Designated

            );               
   }
}