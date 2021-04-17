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

    Core = 5,

    Refs = 8,

    Api = 9,

    BitMasks = 10,

    Term = 11,

    Files = 12,

    Sys = 13,

    Asci = 14,

    Workflow = 15,

    Digital = 18,

    Check = 19,

    Res = 20,

    Lang = 22,

    GMath = 34,

    Polyrand = 36,

    Tools = 41,

    UInt = 42,

    Fsm = 43,

    Driver = 44,

    Interop = 45,

    Cpu = 46,

    CpuShell = Cpu | Shell,

    Gen = 48,

    SFuncs = 49,

    Pipes = 50,

    Clr = 60,

    Cli = 61,

    Canonical = 62,

    CmdSpec = 63,

    CmdExec = 64,

    Tables = 65,

    Gather = 66 | Shell,

    SpanBlocks = 67,

    BitVectors = 100,

    BitSpans = 102,

    BitStrings = 103,

    BitGrids = 104,

    BitPack = 105,

    BitSvc = 106,

    BitFields = 107,

    BitFieldsShell = BitFields | Shell,

    BitSuite = 108,

    BitCore = 109,

    BitMatrix = 110,

    MathSvc = 111,

    Logix = 112,

    LibM = 113,

    Matrix = 114,

    Machines = 115,

    Merge = 116,

    Blocked = 118,

    Nats = 119,

    Mkl = 120,

    Stats = 121,

    Dynamic = 122,

    DynamicShell = Dynamic | Shell,

    Asm = 123,

    AsmLang = 124,

    AsmLangG = 125,

    AsmCore = 126,

    AsmCases = 127,

    AsmRun = 128,

    External = 130,

    Capture = 131,

    Evaluate = 132,

    Extract = 134,

    BitNumbers = 135,

    BitNumbersShell = BitNumbers | Shell,

    DVec = 136,

    GVec = 140,

    VSvc = 142,

    Circuits = 144,

    Unsigned = 146,

    Apps = 150,

    Validity = 156,

    Xed = 160,

    CpuDsl = 161,

    AsmCatalogs = 162,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    Run = 200,

    Machine = 201,

    Control = 202,

    GenApp = 203,

    AsmZ = 204,

    Universe = 255,

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