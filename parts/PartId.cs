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

    Blank01 = 5020,

    Blank02 = 5030,

    Blank03 = 5040,

    Evaluate = 5100,

    Nats = 225, NatsTest = Nats | Test,

    Math = 45, MathTest = Math | Test, 
    
    GMath = 50, GMathTest = GMath | Test, 
               
    BitSuite = 500, 
    
    BitCore = 80, 

    BitTest = BitSuite | Test,

    BitFields = 90, 
    
    BitVectors = 100, 
    
    VBits = 110, 
    
    BitSpan = 170, 
    
    BitString = 230, 
    
    BitGrids = 700, 
    
    BitPack = 710,

    MathSvc = 51, 

    MathSvcTest = MathSvc | Test,

    BitSvc = 81,

    BitSvcTest = BitSvc | Test,

    
    Logix = 120, LogixTest = Logix | Test, 
    
    Asm = 300,  AsmTest = Asm | Test, 
    
    AsmTypes = 302, AsmModels = 304, AsmCore = 310, AsmDecoder = 314,
        
    AsmApp = Asm | App,

    Vectors = 858, VectorTest = Vectors | Test,
    
    VData = 331, 

    FVec = 334, 

    DVec = 332, 
    
    GVec = 333, GVecTest = GVec | Test, 
    
    VSvc = 75, 
    
    VSvcTest = VSvc | Test,
    
    Circuits = 720,
        
    LibM = 150, LibMTest = LibM | Test,

    Matrix = 160, MatrixTest = Matrix | Test,

    Machines = 180, MachinesTest = Machines | Test,
    
    MklApi = 220, MklApiTest = MklApi | Test,

    Stats = 240, StatsTest = Stats | Test,

    Blocks = 260, BlocksTest = Blocks | Test,

    Agency = 270, 
            
    Dynamic = 290, DynamicTest = Dynamic | Test,
    
    Identity = 360, IdentityTest = Identity | Test,

    Cil = 390, CilTest = Cil | Test,

    Permute = 400, PermuteTest = Permute | Test,

    Fixed = 250,  FixedTest = Fixed | Test,
    
    Polyrand = 420,

    Seed = 802, 
    
    Typed = 846, 
    
    Time = 350, 
    
    Graphs = 370,
    
    Symbolic = 410, 
    
    Textual = 810, 
    
    Collective = 804, 
    
    Reflective = 808, 
    
    Canonical = 812, 
    
    SFuncs = 816,

    Cast = 842, Memories = 814, 
    
    Custom = 818,

    Identify = 820, Kinds = 822, Api = 824,
    
    Messages = 840, Apps = 828,

    Tuples = 826,
    
    Numeric = 830,  NumericTest = Numeric | Test,

    Flow = 850, Enums = 852, Reports = 832,
    
    Core = 836,

    Checks = 848,
            
    Contained = 854,

    MergeTest = 5000,

    Spans = 5005,


    Validity = 432,

    ValidityVectors = 436,

    CoreTest = Core | Test,

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}