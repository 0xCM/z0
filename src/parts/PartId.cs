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

    Control = 5010,

    Evaluate = 5100,

    Archives = 5110,

    Extract = 5120,

    Nats = 225, NatsTest = Nats | Test,

    Math = 45,     
    
    GMath = 50, 

    MathSvc = 51, 

    MathTest = Math | Test, 

    Structured = 999,
    
    BitSuite = 500, 
    
    BitCore = 80, 

    BitMatrix = 833,
    
    BitsTest = BitSuite | Test,

    BitFields = 90, 
    
    BitVectors = 100, 
    
    VBits = 110, 
    
    BitSpan = 170, 
    
    BitString = 230, 
    
    BitGrids = 700, 
    
    BitPack = 710,

    BitSvc = 81,

    BitMasks = 903,

    BitSvcTest = BitSvc | Test,
    
    Logix = 120, LogixTest = Logix | Test, 
    
    Asm = 300,  AsmTest = Asm | Test,

    AsmD = 302,

    AsmDTest = AsmD | Test,

    Codes = 303,
    
    Capture = 316,

    CaptureTest = Capture | Test, 
        
    AsmDecoder = 314,
        
    AsmApp = Capture | App,

    AsmChecks = 3333,

    Vectors = 858, VectorsTest = Vectors | Test,
    
    VData = 331, 

    FVec = 334, 

    DVec = 332, 
    
    GVec = 333, GVecTest = GVec | Test, 
    
    VSvc = 75, 
    
    VSvcTest = VSvc | Test,
    
    Circuits = 720,

    Blocked = 8399,
        
    LibM = 150, LibMTest = LibM | Test,

    Matrix = 160, MatrixTest = Matrix | Test,

    Machines = 180, MachinesTest = Machines | Test,

    Machine = 185,
    
    MklApi = 220, MklApiTest = MklApi | Test,

    Stats = 240, StatsTest = Stats | Test,

    Blocks = 260, BlocksTest = Blocks | Test,

    Agency = 270, 
            
    Dynamic = 290, DynopsTest = Dynamic | Test,
    
    Identity = 360, IdentityTest = Identity | Test,

    Cil = 390, CilTest = Cil | Test,

    Permute = 400, PermuteTest = Permute | Test,

    Fixed = 250,  FixedTest = Fixed | Test,
    
    Polyrand = 420,

    Monadic = 769,

    Configure = 771,

    Seed = 802, 
    

    SeedTest = Seed | Test,
    
    Typed = 846, 
    
    Time = 350, 
    
    Graphs = 370,
    
    Symbolic = 410, 
    
    Textual = 810, TextualTest = Textual | Test,
    
    Collective = 804, 
    
    Reflective = 808, 
    
    Canonical = 812, 
    
    Cast = 842, 
    
    Memories = 814,  MemoriesTest = Memories | Test,
    
    Identify = 820, Kinds = 822, 
            
    
    Messages = 840, 
    
    Apps = 828, AppsTest = Apps | Test,

    Tuples = 826,
    
    Numeric = 830,  NumericTest = Numeric | Test,

    Flow = 850, Enums = 852, Reports = 832,
    
    Core = 836,

    Checks = 848,
            
    Contained = 854,

    Spans = 5005,

    Validate = 10000,

    Validity = 432,

    VCheck = 436,

    LSquare = 9831,

    ZXed = 25000,

    Commands = ZXed + 1,

    CoreTest = Core | Test,

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}