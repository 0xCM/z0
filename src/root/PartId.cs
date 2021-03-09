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

    Root = 1,

    Part = 2,

    Konst = 3,

    Math = 4,

    Refs = 8,

    Api = 9,

    BitMasks = 10,

    Digital = 18,

    Check = 19,

    Res = 20,

    Lang = 22,

    GMath = 34,

    Polyrand = 36,

    DynoShell = 40,

    Tools = 41,

    UInt = 42,

    Fsm = 43,

    Driver = 44,

    Interop = 45,

    Dsl = 46,

    Gen = 47,

    Cli = 48,

    Canonical = 49,

    CmdSpec = 50,

    CmdExec = 51,

    BitVectors = 100,

    BitSpans = 102,

    BitStrings = 103,

    BitGrids = 104,

    BitPack = 105,

    BitSvc = 106,

    BitFields = 107,

    BitSuite = 108,

    BitCore = 109,

    BitMatrix = 110,

    MathSvc = 111,

    Logix = 112,

    LibM = 113,

    Matrix = 114,

    Machines = 115,

    Merge = 116,

    Memory = 117,

    Blocked = 118,

    Nats = 119,

    Mkl = 120,

    Stats = 121,

    Dynamic = 122,

    Asm = 123,

    AsmLang = 124,

    AsmLangG = 125,

    External = 130,

    Capture = 131,

    Evaluate = 132,

    Extract = 134,


    DVec = 136,

    GVec = 140,

    VSvc = 142,

    Circuits = 144,

    Unsigned = 146,

    Apps = 150,

    Validity = 156,

    Xed = 160,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    Run = 200,

    Machine = 201,

    Control = 202,

    GenApp = 203,

    AsmZ = 204,

    // ~ Test
    // ~ -------------------------------------------------------------------------------

    PolyrandTest = Polyrand | Test,

    LogixTest = Logix | Test,

    LibMTest = LibM | Test,

    MachinesTest = Machines | Test,

    MathTest = Math | Test,

    BitsTest = BitSuite | Test,

    MklApiTest = Mkl | Test,

    AsmTest = Asm | Test,

    UnsignedTest = Unsigned | Test,

    GVecTest = GVec | Test,

    ToolsTest = Tools | Test,

    TestDriver = Driver | Test,

    UIntTest = UInt | Test,

    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Shell = ushort.MaxValue  + 1,

    Svc = Shell << 1,

    Test = Shell << 2,
}