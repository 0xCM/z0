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

        TypeNats = T02,

        TypeNatsTest = TypeNats | Test,

        DataCore = T03,

        CoreFunc = T04,

        CoreFuncTest = CoreFunc | Test,

        GMath = T05,

        GMathTest = GMath | Test,

        Intrinsics = T07,

        IntrinsicsTest = Intrinsics | Test,

        BitCore = T08,

        BitCoreTest = BitCore | Test,

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

        Control = T50,

        Test = T63
    }

    public static class AssemblyIdOps
    {
        [MethodImpl(Inline)]
        public static string Format(this AssemblyId id)
        {
            const string TestSuffix = ".test";

            var test = id.IsTestAssembly();
            var @base = id.WithoutTestFlag().ToString().ToLower();
            return @base + (test ? TestSuffix : string.Empty);
        }

        [MethodImpl(Inline)]
        public static bool IsTestAssembly(this AssemblyId a)
            => (a & AssemblyId.Test) != 0;
        
        [MethodImpl(Inline)]
        public static AssemblyId WithoutTestFlag(this AssemblyId a)
            => a & ~ AssemblyId.Test;

        [MethodImpl(Inline)]
        public static AssemblyId WithTestFlag(this AssemblyId a)
            => a | AssemblyId.Test;
    }
}