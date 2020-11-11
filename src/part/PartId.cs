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

    Konst = 3,

    Math = 4,

    BitMasks = 5,

    Win = 6,

    Expressive = 7,

    Refs = 8,

    Api = 9,

    Domain = 18,

    Check = 19,

    Imagine = 20,

    KonstShell = 21,

    Lang = 22,

    Memories = 24,

    GMath = 34,

    Polyrand = 36,

    DynoShell = 40,

    Tools = 41,

    Sln = 42,

    // ~ 50
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Monitor = 41,

    ToolCli = 43,

    Run = 50,

    Canonical = 63,

    Bits = 70,

    Unity = 71,

    CheckDynamic = 72,

    MathTest = 73,

    Commands = 75,

    // ~ 100
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    BitVectors = 100,

    BitSpans = 102,

    BitStrings = 103,

    BitGrids = 104,

    BitPack = 105,

    BitSvc = 106,

    BitFields = 108,

    BitSuite = 109,

    BitCore = 110,

    BitMatrix = 111,

    MathSvc = 114,

    Logix = 115,

    LibM = 116,

    Matrix = 117,

    Machines = 118,

    Merge = 119,

    Identity = 120,

    LSquare = 121,

    Blocked = 125,

    Nats = 133,

    Mkl = 134,

    Stats = 135,

    Blocks = 136,

    Dynamic = 137,

    Fixed = 138,

    VBlock = 139,

    Asm = 140,

    External = 141,

    Machine = 143,

    Capture = 144,

    Evaluate = 146,

    Extract = 148,

    FVec = 150,

    DVec = 151,

    GVec = 152,

    VSvc = 153,

    Circuits = 154,

    Unsigned = 157,

    Identify = 158,

    Apps = 160,

    Numeric = 161,

    Validity = 163,

    Xed = 165,

    Control = 180,

    AsmModels = 181,

    AsmServices = 186,

    Derivatives = 190,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    ResPack = 200,

    WfActors = 201,

    WfCore = 202,

    // ~ 300
    // ~ -------------------------------------------------------------------------------

    // ~ 512
    // ~ -------------------------------------------------------------------------------

    AsmShell = 512,

    // ~ Test
    // ~ -------------------------------------------------------------------------------

    IdentityTest = Identity | Test,

    LogixTest = Logix | Test,

    LibMTest = LibM | Test,

    MachinesTest = Machines | Test,

    BitsTest = BitSuite | Test,

    MklApiTest = Mkl | Test,

    AsmTest = Asm | Test,

    UnsignedTest = Unsigned | Test,

    GVecTest = GVec | Test,

    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Shell = ushort.MaxValue  + 1,

    Svc = Shell << 1,

    Test = Shell << 2,
}