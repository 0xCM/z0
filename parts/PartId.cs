//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

/// <summary>
/// Defines identifiers for assemblies that comprise this ... monstrosity?
/// </summary>
public enum PartId : ulong
{
    None = 0,
            
    Root = 12, RootTest = Root | Test,

    Nats = 225, NatsTest = Nats | Test,

    CoreFunc = 41, CoreFuncTest = CoreFunc | Test,

    Math = 45, MathTest = Math | Test, 
    
    GMath = 50, MathSvc = 51, 

    GMathTest = GMath | Test, 
        
    BitSuite = 500, BitCore = 80, BitFields = 90, BitVectors = 100, VBits = 110, BitSpan = 170, BitString = 230, BitGrids = 700, BitPack = 710,

    BitTest = BitSuite | Test,
    
    Logix = 120, LogixTest = Logix | Test, 
    
    Asm = 300, AsmTypes = 302, AsmModels = 304, AsmCore = 310, AsmDecoder = 314,

    AsmTest = Asm | Test, AsmApp = Asm | App,

    Intrinsics = 70, Vectorized = 330, VData = 331, DVec = 332, GVec = 333, FVec = 334, VSvc = 75, Circuits = 720,

    IntrinsicsTest = Intrinsics | Test, VectorizedTest = Vectorized | Test,
    
    LibM = 150, LibMTest = LibM | Test,

    Matrix = 160, MatrixTest = Matrix | Test,

    Machines = 180, MachinesTest = Machines | Test,
    
    MklApi = 220, MklApiTest = MklApi | Test,

    Stats = 240, StatsTest = Stats | Test,

    Blocks = 260, BlocksTest = Blocks | Test,

    Agency = 270, WorkflowTest = Agency | Test,

    Analogs = 280, AnalogsTest = Analogs | Test,

    Dynamic = 290, DynamicTest = Dynamic | Test,
    
    Identity = 360, IdentityTest = Identity | Test,

    Cil = 390, CilTest = Cil | Test,

    Permute = 400, PermuteTest = Permute | Test,

    Fixed = 250,  FixedTest = Fixed | Test,
    
    Polyrand = 420,

    Seed = 802, Typed = 846, Time = 350, Graphs = 370,
    
    Symbolic = 410, 
    
    Textual = 810, Collective = 804, Reflective = 808, Monadic = 806,

    Canonical = 812, 
    
    SFuncs = 816,

    Cast = 842, Memories = 814, 
    
    Custom = 818,

    Identify = 820, Kinds = 822, Api = 824,
    
    Messages = 840, Apps = 828,

    Numeric = 830, Tuples = 826,
                        
    Flow = 850, Enums = 852, Reports = 832,
    
    Core = 836,

    Checks = 848,
            
    Contained = 854,

    Code = 856,

    Vectors = 858,

    Z = 1024,

    TestLib = 430,

    Validity = 432,

    ValidityCore = 434,

    ValidityVectors = 436,

    CoreTest = Core | Test,

    ValidityTest = Validity | Test,

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}