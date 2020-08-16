//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

/// <summary>
/// Defines identifiers for assemblies that comprise this ... monstrosity?
/// </summary>
public enum PartId : ulong
{
    None = 0,

    Part = 1,

    Sys = 2,
    
    Domain = 3,

    Konst = 5,

    Math = 7,     

    Expressive = 10,

    Imagine = 12,

    Flow = 13,

    Seed = 17,     

    Memories = 23,

    Kinds = 28, 
    
    Tools = 29,
    
    Monitor = 30,

    // ~ 50
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    
    Run = 50,

    Data = 51,

    Tables = 52,
    
    Canonical = 63, 
    
    Bits = 70,
    Win = 71,

    // ~ 100
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    BitVectors = 100, 

    VBits = 101, 
    
    BitSpans = 102, 
    
    BitStrings = 103, 
    
    BitGrids = 104, 
    
    BitPack = 105,

    BitSvc = 106,

    BitMasks = 107,

    BitFields = 108, 

    BitSuite = 109, 
    
    BitCore = 110, 

    BitMatrix = 111,
    
    GMath = 113, 

    MathSvc = 114, 

    Logix = 115, 
    
    LibM = 116, 
    
    Matrix = 117, 
    
    Machines = 118, 

    Polyrand = 119,

    Identity = 120, 
    
    LSquare = 121,
    
    Blocked = 125,

    MetaReader = 126,

    
    Nats = 133, 

    Mkl = 134, 
    
    Stats = 135, 
    
    Blocks = 136, 
    
    Dynamic = 137, 
    
    Fixed = 138,  

    VBlock = 139,

    Asm = 140,  
    
    Machine = 143,

    Capture = 144,

    Cil = 145, 

    Evaluate = 146,

    Extract = 148,

    VData = 149, 

    FVec = 150, 

    DVec = 151, 
    
    GVec = 152, 
    
    VSvc = 153, 
    
    Circuits = 154,

    Vectors = 155, 

    Structured = 156,

    Symbolic = 157, 
    
    Identify = 158, 
                  
    Apps = 160,     
    
    Numeric = 161,  
        
    Core = 162,
         
    Validity = 163,

    VCheck = 164,

    ZXed = 165,
    
    V0 = 170,

    Control = 180,
    
    AsmModels = 181,

    AsmRun = 182,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    ResPack = 200,

    WfActors = 201,

    WfCore = 202,

    // ~ 300
    // ~ -------------------------------------------------------------------------------

    Basement = 300,

    Substructure = 301,

    Dynamo = 302,

    Collections = 303,
    
    Floor = 305,

    Json = 306,

    Lang = 307,

    Messaging = 308,

    Files = 310,

    Processes = 311,

    Command = 312,

    Commands = 313,
    
    Agents = 315,

    Etude = 325,

    Services = 326,

    // ~ 2000
    // ~ -------------------------------------------------------------------------------
    

    // ~ Test
    // ~ -------------------------------------------------------------------------------

    IdentityTest = Identity | Test,

    LogixTest = Logix | Test, 

    LibMTest = LibM | Test,

    MachinesTest = Machines | Test,

    MathTest = Math | Test, 
    
    BitsTest = BitSuite | Test,
    
    MklApiTest = Mkl | Test,

    DynopsTest = Dynamic | Test,

    AsmTest = Asm | Test,

    
    AsmDTest = AsmModels | Test,

    SymbolicTest = Symbolic | Test,

    GVecTest = GVec | Test,     


    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}