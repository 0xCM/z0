//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

using static Z0.Pow2;    

/// <summary>
/// Defines identifiers for known system assemblies
/// </summary>
public enum AssemblyId : ulong
{
    None = 0,
            
    Root = 12,

    RootTest = Root | Test,

    Nats = 225,

    NatsTest = Nats | Test,

    CoreFunc = 41,

    CoreFuncTest = CoreFunc | Test,

    Math = 45,

    MathTest = Math | Test,
    
    GMath = 50,

    GMathTest = GMath | Test,

    MathSvc = 51,

    Intrinsics = 70,

    IntrinsicsTest = Intrinsics | Test,

    IntrinsicsSvc = 75,

    BitCore = 80,

    BitSuite = 500,
    
    BitTest = BitSuite | Test,

    BitCoreSvc = 505,

    BitFields = 90,

    BitVectors = 100,

    BitGrids = 700,

    Logix = 120,

    LogixTest = Logix | Test,

    Asm = 130,

    AsmTest = Asm | Test,

    Data = 140,

    LibM = 150,

    LibMTest = LibM | Test,

    Matrix = 160,

    MatrixTest = Matrix | Test,

    BitSpan = 170,

    BitSpanTest = BitSpan | Test,

    Machines = 180,

    MachinesTest = Machines | Test,

    RngCore = 190,

    RngEmitters = 200,

    RngSuite = 210,

    RngTest = RngSuite | Test,
    
    MklApi = 220,

    MklApiTest = MklApi | Test,

    BitString = 230,

    BitStringTest = BitString | Test,

    StatCore = 240,

    StateCoreTest = StatCore | Test,

    Fixed = 250,

    FixedTest = Fixed | Test,

    Blocks = 260,

    BlocksTest = Blocks | Test,

    WorkflowRuntime = 270,

    WorkflowTest = WorkflowRuntime | Test,

    Analogs = 280,

    AnalogsTest = Analogs | Test,

    Dynamic = 290,

    DynamicTest = T29 | Test,
    
    AsmCore = 300,

    AsmEncoder = 310,
    
    AsmDecoder = 320,

    Vectorized = 330,

    VectorizedTest = Vectorized | Test,

    WorkflowCore = 340,

    Time = 350,

    TimeTest = Time | Test,

    Identity = 360,

    IdentityTest = Identity | Test,

    Graphs = 370,

    GraphTest = Graphs | Test,

    Containers = 380,

    Cil = 390,

    CilTest = Cil | Test,

    ContainerTest = Containers | Test,

    Control = 1000,        

    Svc = T16,

    Test = T17
}

[AttributeUsage(AttributeTargets.Assembly)]
public class AssemblyIdAttribute : Attribute
{

    public AssemblyIdAttribute(object id)
    {
        Id = (AssemblyId)id;
    }

    public AssemblyId Id {get;}
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Pow2;
    using static Root;


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

        [MethodImpl(Inline)]
        public static AssemblyId Id(this Assembly src)
            => src.FindTag<AssemblyIdAttribute>().MapValueOrDefault(a => a.Id);
    }
}