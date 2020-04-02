//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

using Z0;

/// <summary>
/// Defines identifiers for known system assemblies
/// </summary>
/// <remarks>
/// Somehow, there needs to be a convenient extensibility mechansim provided for
/// the parti identifier and the type code collection that follows. 
/// </remarks>
public enum PartId : ulong
{
    None = 0,
            
    Root = 12,

    RootTest = Root | Test,

    Nats = 225 | Lib,

    NatsTest = Nats | Test,

    CoreFunc = 41,

    CoreFuncTest = CoreFunc | Test,

    Math = 45 | Lib,

    MathTest = Math | Test,
    
    GMath = 50 | Lib,

    GMathTest = GMath | Test,

    MathSvc = 51,

    Intrinsics = 70,

    IntrinsicsTest = Intrinsics | Test,

    VSvc = 75,

    BitCore = 80,

    BitSuite = 500,
    
    BitTest = BitSuite | Test,

    BitCoreSvc = 505,

    BitFields = 90,

    BitVectors = 100,

    VBits = 110,

    Logix = 120,

    LogixTest = Logix | Test,

    Asm = 300,

    AsmTypes = 302,

    AsmModels = 304,

    AsmCore = 310,

    AsmEncoder = 312,
    
    AsmDecoder = 314,

    AsmTest = Asm | Test,

    AsmApp = Asm | App,

    Vectorized = 330,

    Data = 140,

    LibM = 150,

    LibMTest = LibM | Test,

    Matrix = 160,

    MatrixTest = Matrix | Test,

    BitSpan = 170,

    BitSpanTest = BitSpan | Test,

    Machines = 180,

    MachinesTest = Machines | Test,

    
    MklApi = 220,

    MklApiTest = MklApi | Test,

    BitString = 230,

    BitStringTest = BitString | Test,

    Stats = 240,

    StatsTest = Stats | Test,

    Fixed = 250,

    FixedTest = Fixed | Test,

    Blocks = 260,

    BlocksTest = Blocks | Test,

    WorkflowRuntime = 270,

    WorkflowTest = WorkflowRuntime | Test,

    Analogs = 280,

    AnalogsTest = Analogs | Test,

    Dynamic = 290,

    DynamicTest = Dynamic | Test,
    
    VData = 331,

    DVec = 332,

    GVec = 333,

    FVec = 334,

    DVecTest = DVec | Test,

    GVecTest = GVec | Test,

    VectorizedTest = Vectorized | Test,

    WorkflowCore = 340,

    Time = 350,

    TimeTest = Time | Test,

    Identity = 360,

    IdentityTest = Identity | Test,

    Graphs = 370,

    GraphTest = Graphs | Test,

    Containers = 380,

    ContainerTest = Containers | Test,

    Cil = 390,

    CilTest = Cil | Test,

    Permute = 400,

    PermuteTest = Permute | Test,
    
    Symbolic = 410,

    Polyrand = 420,

    PolyrandTest = Polyrand | Test,

    Testing = 430,

    TestLib = Testing | Lib,

    TestApp = Testing | App,

    Validity = 432,

    ValidityCore = 434,

    ValidityVectors = 436,

    ValidityTest = Validity | Test,
        
    BitGrids = 700,

    BitPack = 710,

    Circuits = 720,

    Feeders = 800,

    Seed = 802,

    Collective = 804,

    Monadic = 806,

    Reflective = 808,

    Textual = 810,

    Canonical = 812,

    Memories = 814,

    SFuncs = 816,

    Custom = 818,

    Identify = 820,

    Kinds = 822,

    Api = 824,
    
    Tuples = 826,
        
    Apps = 828,
    
    Numeric = 830,

    Reports = 832,

    Errors = 834,    

    Core = 836,

    Rng = 838,

    Messages = 840,

    Cast = 842,

    Interval = 844,

    Typed = 846,

    Checks = 848,
    
    Flow = 850,

    Z = 1024,

    Svc = ushort.MaxValue + 1,

    Test = Svc << 1,

    App = Test << 1,

    Lib = App << 1,
}

public enum UserTypeId : uint
{
    None = 0,

    BitId = 256,

    DurationId = BitId + 1,

    BoxedNumberId = DurationId + 1,

    FirstId = BitId,    
}


public static class PartIdentity
{
    public sealed class Api : PartId<Api> { public override PartId Id => PartId.Api;}

    public sealed class Canonical : PartId<Canonical> { public override PartId Id => PartId.Canonical; }

    public sealed class Collective : PartId<Collective> { public override PartId Id => PartId.Collective;}

    public sealed class Components : PartId<Components> { public override PartId Id => PartId.Seed;}

    public sealed class Custom : PartId<Custom> { public override PartId Id => PartId.Custom;}

    public sealed class Dynamic : PartId<Dynamic> { public override PartId Id => PartId.Dynamic;}

    public sealed class Identify : PartId<Identify> { public override PartId Id => PartId.Identify; }

    public sealed class Kinds : PartId<Kinds> { public override PartId Id => PartId.Kinds;}

    public sealed class Math : PartId<Math> { public override PartId Id => PartId.Math;}

    public sealed class Memories : PartId<Memories> { public override PartId Id => PartId.Memories;}

    public sealed class Monadic : PartId<Monadic> { public override PartId Id => PartId.Monadic; }

    public sealed class Nats : PartId<Nats> { public override PartId Id => PartId.Nats;}

    public sealed class Reflective : PartId<Reflective> { public override PartId Id => PartId.Reflective; }

    public sealed class Vectorized : PartId<Vectorized> { public override PartId Id => PartId.Vectorized;}

    public sealed class SFuncs : PartId<SFuncs> { public override PartId Id => PartId.SFuncs;}

    public sealed class Symbolic : PartId<Symbolic> { public override PartId Id => PartId.Symbolic;}

    public sealed class Textual : PartId<Textual> { public override PartId Id => PartId.Textual;}

    public sealed class Root : PartId<Root> { public override PartId Id => PartId.Root;}
}