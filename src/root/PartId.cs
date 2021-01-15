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

    Domain = 18,

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

    Cli = 50,

    Canonical = 63,

    CmdSpec = 75,

    CmdExec = 76,

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

    Blocked = 125,

    Nats = 133,

    Mkl = 134,

    Stats = 135,

    Dynamic = 137,

    Asm = 140,

    External = 141,

    Capture = 144,

    Evaluate = 146,

    Extract = 148,

    FVec = 150,

    DVec = 151,

    GVec = 152,

    VSvc = 153,

    Circuits = 154,

    Unsigned = 157,

    Apps = 160,

    Validity = 163,

    Xed = 165,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    Run = 200,

    Machine = 201,

    Control = 202,

    GenApp = 203,

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