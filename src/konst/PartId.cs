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

    Konst = 1,

    Models = 2,

    Part = 3,

    // ~ 50
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Enhanced = 50,
    
    Canonical = 63, 
    
    Bits = 70,
    
    // ~ 100
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    BitVectors = 100, 

    VBits = 101, 
    
    BitSpans = 102, 
    
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

    Artistry = 129,

    Spans = 131,
    
    Imagine = 132,
    
    IdentityTest = Identity | Test,

    LogixTest = Logix | Test, 

    LibMTest = LibM | Test,

    MachinesTest = Machines | Test,

    MathTest = Math | Test, 
    
    BitsTest = BitSuite | Test,

    // ~ 200
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
    Nats = 200, 

    MklApi = 201, 
    
    Stats = 202, 
    
    Blocks = 203, 
    
    Dynamic = 205, 
    
    Fixed = 206,  

    VBlock = 207,
    
    FixedTest = Fixed | Test,

    MklApiTest = MklApi | Test,


    DynopsTest = Dynamic | Test,


    // ~ 300
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
    Asm = 300,  

    AsmB = 301,
    
    AsmD = 302,

    Codes = 305,

    AsmDecoder = 306,

    Machine = 320,

    Capture = 321,

    Cil = 322, 

    AsmTest = Asm | Test,

    AsmDTest = AsmD | Test,

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

    Structured = 708,

    GVecTest = GVec | Test,     


    // ~ 2000
    // ~ -------------------------------------------------------------------------------
    
    Symbolic = 2003, 
    
    Identify = 2010, 
    
    Kinds = 2011, 
                   
    Apps = 2013,     
    
    Numeric = 2015,  
        
    Core = 2019,
         
    Validate = 2023,

    Validity = 2024,

    VCheck = 2025,

    Seed = 2027,     

    ZXed = 2028,

    SymbolicTest = Symbolic | Test,


    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}

/// <summary>
/// Defines identifiers for external library dependencies, probably native
/// </summary>
public enum ExternId : ulong
{
    None = 0,

    OpenLibM = 1,

    CBlas = 2,

    LAPack = 3,

    LAPacke = 4,

    Vml = 5,

    Vsl = 6,
}

[AttributeUsage(AttributeTargets.Assembly)]
public class PartIdAttribute : Attribute
{    
    public PartIdAttribute(object id)
    {
        Id = (PartId)id;
    }

    public PartId Id {get;}
}