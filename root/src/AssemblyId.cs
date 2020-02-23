//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Pow2;
    using static Root;

    /// <summary>
    /// Defines identifiers for known system assemblies
    /// </summary>
    public enum AssemblyId : ulong
    {
        None = 0,
        
        Empty = T00,
        
        Root = T01,

        RootTest = Root | Test,

        Nats = T02,

        NatsTest = Nats | Test,

        DataCore = T03,

        CoreFunc = T04,

        CoreFuncTest = CoreFunc | Test,

        GMath = T05,

        GMathTest = GMath | Test,

        GMathSvc = GMath | Svc,

        Intrinsics = T07,

        IntrinsicsTest = Intrinsics | Test,

        IntrinsicsSvc = Intrinsics | Svc,

        BitCore = T08,

        BitCoreTest = BitCore | Test,

        BitCoreSvc = BitCore | Svc,

        BitFields = T09,

        BitFieldsTest = BitFields | Test,

        BitVectors = T10,

        BitVectorsTest = BitVectors | Test,

        BitGrids = T11,

        BitGridsTest = BitGrids | Test,

        Logix = T12,

        LogixTest = Logix | Test,

        Polyrand = T13,

        PolyrandTest = Polyrand | Test,

        AsmCore = T14,

        AsmCoreTest = AsmCore | Test,

        Data = T15,

        LibM = T16,

        LibMTest = LibM | Test,

        Matrix = T17,

        MatrixTest = Matrix | Test,

        BitSpan = T18,

        BitSpanTest = BitSpan | Test,

        Machines = T19,

        MachinesTest = Machines | Test,

        RngCore = T20,

        MathObjects = T21,
        
        MklApi = T22,

        MklApiTest = MklApi | Test,

        FastOps = T23,

        FastOpsTest = FastOps | Test,

        Validation = T24,

        ValidationTest = Validation | Test,

        Fixed = T25,

        FixedTest = Fixed | Test,

        DataBlocks = T26,

        DataBlocksTest = DataBlocks | Test,

        Workflow = T27,

        WorkflowTest = Workflow | Test,

        Analogs = T28,

        AnalogsTest = Analogs | Test,
        
        Control = T50,

        Svc = T62,

        Test = T63
    }

    public static class AssemblyIdOps
    {
        [MethodImpl(Inline)]
        public static string Format(this AssemblyId id)
        {
            const string TestSuffix = ".test";
            const string SvcSuffix = ".svc";
            const string BaseSuffix = "";

            var @base = id.Base();
            var dst = @base.ToString().ToLower();
                        
            if(id.IsTest())
                return dst + TestSuffix;
            else if(id.IsSvc())
                return dst + SvcSuffix;
            else
                return dst + BaseSuffix;

            // var test = id.IsTest();
            // var @base = id.WithoutTest().ToString().ToLower();
            // return @base + (test ? TestSuffix : string.Empty);
        }

        [MethodImpl(Inline)]
        public static bool IsTest(this AssemblyId a)
            => (a & AssemblyId.Test) != 0;

        [MethodImpl(Inline)]
        public static bool IsSvc(this AssemblyId a)
            => (a & AssemblyId.Svc) != 0;

        [MethodImpl(Inline)]
        public static AssemblyId WithoutTest(this AssemblyId a)
            => a & ~ AssemblyId.Test;

        [MethodImpl(Inline)]
        public static AssemblyId WithTest(this AssemblyId a)
            => a | AssemblyId.Test;

        [MethodImpl(Inline)]
        public static AssemblyId WithoutSvc(this AssemblyId a)
            => a & ~ AssemblyId.Svc;

        [MethodImpl(Inline)]
        public static AssemblyId WithSvc(this AssemblyId a)
            => a | AssemblyId.Svc;

        [MethodImpl(Inline)]
        public static AssemblyId Base(this AssemblyId a)
            => a.WithoutSvc().WithoutTest();

    }
}