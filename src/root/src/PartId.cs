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

    External = 2,

    Part = 3,

    PartTest = Part | Test,

    Math = 4,

    Core = 5,

    [Symbol("core.test")]
    CoreTest = Core | Test,

    Api = 9,

    BitMasks = 10,

    Term = 11,

    Sys = 13,

    Asci = 14,

    Workflow = 15,

    PolySource = 16,

    Digital = 18,

    Check = 19,

    Res = 20,

    Lang = 22,

    GMath = 34,

    Polyrand = 36,

    Calc = 37,

    Sources = 38,

    [Symbol("calc.shell")]
    CalcShell = Calc | Shell,

    Events = 40,

    Tools = 41,

    [Symbol("tools.shell")]
    ToolShell = Tools | Shell,

    Tooling = 42,

    Fsm = 43,

    Driver = 44,

    Interop = 45,

    Cpu = 46,

    [Symbol("cpu.shell")]
    CpuShell = Cpu | Shell,

    Gen = 48,

    SFuncs = 49,

    Pipes = 50,

    Agents = 51,

    Clr = 60,

    Cli = 61,

    Canonical = 62,

    Symbolic = 63,

    Tables = 65,

    Gather = 66 | Shell,

    SpanBlocks = 67,

    Related = 68,

    Minidump = 69,

    Bits = 70,

    BitVectors = 100,

    BitSpans = 102,

    BitStrings = 103,

    BitGrids = 104,

    BitPack = 105,

    BitSvc = 106,

    BitFields = 107,

    [Symbol("bitfields.shell")]
    BitFieldsShell = BitFields | Shell,

    BitSuite = 108,

    BitCore = 109,

    BitMatrix = 110,

    MathSvc = 111,

    Logix = 112,

    LibM = 113,

    Machines = 115,

    Nats = 119,

    Mkl = 120,

    Stats = 121,

    Dynamic = 122,

    [Symbol("dynamic.shell")]
    DynamicShell = Dynamic | Shell,

    Asm = 123,

    [Symbol("asm.g")]
    AsmLang = 124,

    [Symbol("asm.lang.g")]
    AsmLangG = 125,

    [Symbol("asm.core")]
    AsmCore = 126,

    [Symbol("asm.cases")]
    AsmCases = 127,

    AsmRun = 128,

    Capture = 131,

    [Symbol("capture.checks")]
    CaptureChecks = Capture | Checkers,

    Evaluate = 132,

    Extract = 134,

    BitNumbers = 135,

    [Symbol("bitnumbers.shell")]
    BitNumbersShell = BitNumbers | Shell,

    GVec = 140,

    Circuits = 144,

    Unsigned = 146,

    Apps = 150,

    Validity = 156,

    Xed = 160,

    [Symbol("cpu.dsl")]
    CpuDsl = 161,

    [Symbol("asm.catalogs")]
    AsmCatalogs = 162,

    Services = 199,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    Run = 200,

    Machine = 201,

    Control = 202,

    GenApp = 203,

    AsmZ = 204,

    // ~ Test
    // ~ -------------------------------------------------------------------------------

    [Symbol("polyrand.test")]
    PolyrandTest = Polyrand | Test,

    [Symbol("logix.test")]
    LogixTest = Logix | Test,

    LibMTest = LibM | Test,

    [Symbol("machines.test")]
    MachinesTest = Machines | Test,

    [Symbol("math.test")]
    MathTest = Math | Test,

    [Symbol("bits.test")]
    BitsTest = BitSuite | Test,

    MklApiTest = Mkl | Test,

    [Symbol("asm.test")]
    AsmTest = Asm | Test,

    UnsignedTest = Unsigned | Test,

    [Symbol("gvec.test")]
    GVecTest = GVec | Test,


    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    Checkers = byte.MaxValue + 1,

    Shell = ushort.MaxValue  + 1,

    Svc = Shell << 1,

    Test = Shell << 2,

}