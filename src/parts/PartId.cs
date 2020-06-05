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
    
    // ~ 100
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    BitVectors = 100, 
    
    VBits = 101, 
    
    BitSpan = 102, 
    
    BitString = 103, 
    
    BitGrids = 104, 
    
    BitPack = 105,

    BitSvc = 106,

    BitMasks = 107,

    BitFields = 108, 

    BitSuite = 109, 
    
    BitCore = 110, 

    BitMatrix = 111,

    Math = 112,     
    
    GMath = 113, 

    MathSvc = 114, 

    Logix = 115, 
    
    LibM = 116, 
    
    Matrix = 117, 
    
    Machines = 118, 

    Polyrand = 119,

    Identity = 120, 
    
    LSquare = 121,

    Datasets = 122,

    Generate = 123,
    
    Artifacts = 124,

    Blocked = 125,

    MetaReader = 126,

    IdentityTest = Identity | Test,

    LogixTest = Logix | Test, 

    LibMTest = LibM | Test,

    MatrixTest = Matrix | Test,

    MachinesTest = Machines | Test,

    MathTest = Math | Test, 
    
    BitsTest = BitSuite | Test,

    BitSvcTest = BitSvc | Test,

    // ~ 200
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
    Nats = 200, 

    MklApi = 201, 
    
    Stats = 202, 
    
    Blocks = 203, 
    
    Agency = 204, 
            
    Dynamic = 205, 
    
    Fixed = 206,  
    
    FixedTest = Fixed | Test,

    MklApiTest = MklApi | Test,

    StatsTest = Stats | Test,

    BlocksTest = Blocks | Test,

    DynopsTest = Dynamic | Test,

    NatsTest = Nats | Test,

    // ~ 300
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
    Asm = 300,  

    AsmB = 301,
    
    AsmD = 302,

    AsmG = 303,

    AsmChecks = 304,

    Codes = 305,

    AsmDecoder = 306,

    Machine = 320,

    Capture = 321,

    Cil = 322, 

    AsmTest = Asm | Test,

    AsmDTest = AsmD | Test,

    CaptureApp = Capture | App,
    
    CaptureTest = Capture | Test, 
        
    CilTest = Cil | Test,

    SeedTest = Seed | Test,

    // ~ 500
    // ~ -------------------------------------------------------------------------------

    Control = 500,

    Evaluate = 501,

    Archives = 502,

    Extract = 503,


    // ~ 700
    // ~ -------------------------------------------------------------------------------

    VData = 700, 

    FVec = 701, 

    DVec = 702, 
    
    GVec = 703, 
    
    VSvc = 704, 
    
    Circuits = 705,

    Vectors = 706, 

    Permute = 707, 

    Structured = 708,

    PermuteTest = Permute | Test,

    VectorsTest = Vectors | Test,

    GVecTest = GVec | Test,     

    VSvcTest = VSvc | Test,



    // ~ 2000
    // ~ -------------------------------------------------------------------------------

    Time = 2001, 
    
    Graphs = 2002,
    
    Symbolic = 2003, 
    
    Textual = 2004,     
    
    Collective = 2005, 
    
    Reflective = 2006, 
    
    Canonical = 2007, 
    
    Cast = 2008, 
    
    Memories = 2009,  
    
    Identify = 2010, 
    
    Kinds = 2011, 
               
    Messages = 2012, 
    
    Apps = 2013,     

    Tuples = 2014,    
    
    Numeric = 2015,  

    Flow = 2016, 
    
    Enums = 2017, 
    
    Reports = 2018,
    
    Core = 2019,

    Checks = 2020,
            
    Contained = 2021,

    Spans = 2022,

    Validate = 2023,

    Validity = 2024,

    VCheck = 2025,

    Typed = 2026, 

    Seed = 2027,     

    Configure = 2028,

    Monadic = 2029,

    ResV = 2030,

    CoreTest = Core | Test,

    TextualTest = Textual | Test,

    MemoriesTest = Memories | Test,

    AppsTest = Apps | Test,

    NumericTest = Numeric | Test,

    // ~ 9000
    // ~ -------------------------------------------------------------------------------

    ZXed = 9001,

    Commands = 9002,

    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}