//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

using Z0;

/// <summary>
/// Defines identifiers for assemblies that comprise this ... monstrosity?
/// </summary>
public enum PartId : ulong
{
    None = 0,

    [Symbol("root")]
    Root = 1,

    [Symbol("external")]
    External = 2,

    [Symbol("part")]
    Part = 3,

    [Symbol("part.test")]
    PartTest = Part | Test,

    [Symbol("math")]
    Math = 4,

    [Symbol("core")]
    Core = 5,

    [Symbol("core.test")]
    CoreTest = Core | Test,

    [Symbol("api")]
    Api = 9,

    [Symbol("bitmasks")]
    BitMasks = 10,

    [Symbol("term")]
    Term = 11,

    [Symbol("sys")]
    Sys = 13,

    [Symbol("asci")]
    Asci = 14,

    [Symbol("workflow")]
    Workflow = 15,

    [Symbol("polysource")]
    PolySource = 16,

    [Symbol("polyrand")]
    Polyrand = 15,

    [Symbol("polyrand.test")]
    PolyrandTest = Polyrand | Test,

    [Symbol("digital")]
    Digital = 18,

    [Symbol("check")]
    Check = 19,

    Res = 20,

    [Symbol("lang")]
    Lang = 22,

    [Symbol("gmath")]
    GMath = 34,

    [Symbol("calc")]
    Calc = 37,

    [Symbol("calc.shell")]
    CalcShell = Calc | Shell,

    [Symbol("events")]
    Events = 40,

    [Symbol("tools")]
    Tools = 41,

    [Symbol("tools.shell")]
    ToolShell = Tools | Shell,

    [Symbol("tooling")]
    Tooling = 42,

    [Symbol("fsm")]
    Fsm = 43,

    [Symbol("interop")]
    Interop = 45,

    [Symbol("cpu")]
    Cpu = 46,

    [Symbol("cpu.shell")]
    CpuShell = Cpu | Shell,

    [Symbol("gen")]
    Gen = 48,

    [Symbol("gen.shell")]
    GenApp = 203,

    [Symbol("sfuncs")]
    SFuncs = 49,

    [Symbol("pipes")]
    Pipes = 50,

    [Symbol("agents")]
    Agents = 51,

    [Symbol("clr")]
    Clr = 60,

    [Symbol("cli")]
    Cli = 61,

    [Symbol("cli.shell")]
    CliShell = Cli | Shell,

    [Symbol("canonical")]
    Canonical = 62,

    [Symbol("symbolic")]
    Symbolic = 63,

    [Symbol("symbolic.test")]
    SymbolicTest = Symbolic | Test,

    [Symbol("tables")]
    Tables = 65,

    [Symbol("gather")]
    Gather = 66 | Shell,

    [Symbol("spanblocks")]
    SpanBlocks = 67,

    [Symbol("related")]
    Related = 68,

    [Symbol("minidump")]
    Minidump = 69,

    [Symbol("bits")]
    Bits = 70,

    [Symbol("bits.test")]
    BitsTest = Bits | Test,

    [Symbol("bitvectors")]
    BitVectors = 100,

    [Symbol("bitspans")]
    BitSpans = 102,

    [Symbol("bitstrings")]
    BitStrings = 103,

    [Symbol("bitgrids")]
    BitGrids = 104,

    [Symbol("bitpack")]
    BitPack = 105,

    [Symbol("bitfields")]
    BitFields = 107,

    [Symbol("bitfields.shell")]
    BitFieldsShell = BitFields | Shell,

    [Symbol("bitmatrix")]
    BitMatrix = 110,

    [Symbol("logix")]
    Logix = 112,

    [Symbol("libm")]
    LibM = 113,

    [Symbol("libm.test")]
    LibMTest = LibM | Test,

    [Symbol("machines")]
    Machines = 115,

    [Symbol("nats")]
    Nats = 119,

    [Symbol("mkl")]
    Mkl = 120,

    [Symbol("stats")]
    Stats = 121,

    [Symbol("dynamic")]
    Dynamic = 122,

    [Symbol("dynamic.shell")]
    DynamicShell = Dynamic | Shell,

    [Symbol("asm")]
    Asm = 123,

    [Symbol("asm.g")]
    AsmLang = 124,

    [Symbol("asm.lang.g")]
    AsmLangG = 125,

    [Symbol("asm.core")]
    AsmCore = 126,

    [Symbol("asm.cases")]
    AsmCases = 127,

    [Symbol("asm.run")]
    AsmRun = 128,

    [Symbol("capture")]
    Capture = 131,

    [Symbol("capture.checks")]
    CaptureChecks = Capture | Checkers,

    [Symbol("evaluate")]
    Evaluate = 132,

    [Symbol("extract")]
    Extract = 134,

    [Symbol("bitnumbers")]
    BitNumbers = 135,

    [Symbol("bitnumbers.shell")]
    BitNumbersShell = BitNumbers | Shell,

    [Symbol("circuits")]
    Circuits = 144,

    [Symbol("apps")]
    Apps = 150,

    [Symbol("validity")]
    Validity = 156,

    [Symbol("xed")]
    Xed = 160,

    [Symbol("cpu.dsl")]
    CpuDsl = 161,

    [Symbol("asm.catalogs")]
    AsmCatalogs = 162,

    [Symbol("services")]
    Services = 199,

    // ~ 200
    // ~ -------------------------------------------------------------------------------

    [Symbol("run")]
    Run = 200,

    [Symbol("machine")]
    Machine = 201,

    [Symbol("contral")]
    Control = 202,

    [Symbol("asmz")]
    AsmZ = 204,

    // ~ Test
    // ~ -------------------------------------------------------------------------------

    [Symbol("logix.test")]
    LogixTest = Logix | Test,

    [Symbol("machines.test")]
    MachinesTest = Machines | Test,

    [Symbol("math.test")]
    MathTest = Math | Test,

    [Symbol("mkl.test")]
    MklApiTest = Mkl | Test,

    [Symbol("asm.test")]
    AsmTest = Asm | Test,

    [Symbol("gvec.test")]
    GVecTest = Cpu | Test,

    // ~ Classifiers
    // ~ -------------------------------------------------------------------------------

    [Ignore]
    Checkers = byte.MaxValue + 1,

    [Ignore]
    Shell = ushort.MaxValue  + 1,

    [Ignore]
    Svc = Shell << 1,

    [Ignore]
    Test = Shell << 2,
}