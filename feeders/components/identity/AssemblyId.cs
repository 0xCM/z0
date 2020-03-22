//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

/// <summary>
/// Defines identifiers for known system assemblies
/// </summary>
public enum AssemblyId : ulong
{
    None = 0,
            
    Root = 12,

    RootTest = Root | Test,

    Nats = 225 | Lib,

    NatsTest = Nats | Test,

    CoreFunc = 41,

    CoreFuncTest = CoreFunc | Test,

    Math = 45 | Lib,

    MathTest = Math | Test,
    
    GenericNumerics = 50 | Lib,

    GenericNumericsTest = GenericNumerics | Test,

    MathSvc = 51,

    Intrinsics = 70,

    IntrinsicsTest = Intrinsics | Test,

    VSvc = 75,

    BitCore = 80,

    BitSuite = 500,
    
    BitTest = BitSuite | Test,

    BitCoreSvc = 505,

    BitFields = 90,

    BitVectors = 100,

    VBits = 110,

    Logix = 120,

    LogixTest = Logix | Test,

    Asm = 300,

    AsmTest = Asm | Test,

    AsmApp = Asm | App,
    
    AsmCore = 305,

    AsmEncoder = 310,
    
    AsmDecoder = 315,

    Vectorized = 330,

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

    DynamicTest = Dynamic | Test,
    

    VData = 331,

    DVec = 332,

    GVec = 333,

    DVecTest = DVec | Test,

    GVecTest = GVec | Test,

    VectorizedTest = Vectorized | Test,

    WorkflowCore = 340,

    Time = 350,

    TimeTest = Time | Test,

    Identity = 360,

    IdentityTest = Identity | Test,

    Graphs = 370,

    GraphTest = Graphs | Test,

    Containers = 380,

    ContainerTest = Containers | Test,

    Cil = 390,

    CilTest = Cil | Test,

    Permute = 400,

    PermuteTest = Permute | Test,
    
    Symbolic = 410,

    Polyrand = 420,

    PolyrandTest = Polyrand | Test,

    Validity = 430,

    ValidityTest = Validity | Test,
    
    BitGrids = 700,

    BitPack = 710,

    Circuits = 720,

    Testing = 730,

    TestLib = Testing | Lib,

    TestApp = Testing | App,

    Feeders = 1000,

    Components = 1005,

    Collective = 1010,

    Monadic = 1015,

    Reflections = 1020,

    Texting = 1025,

    Canonical = 1030,

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}