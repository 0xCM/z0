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
            
    Root = 12, RootTest = Root | Test,

    Nats = 225, NatsTest = Nats | Test,

    CoreFunc = 41, CoreFuncTest = CoreFunc | Test,

    Math = 45, GMath = 50, MathSvc = 51, 

    MathTest = Math | Test, GMathTest = GMath | Test, 
        
    BitSuite = 500, BitCore = 80, BitFields = 90, BitVectors = 100, VBits = 110, BitSpan = 170, BitString = 230, BitGrids = 700, BitPack = 710,

    BitTest = BitSuite | Test,
    
    Logix = 120, LogixTest = Logix | Test, 
    
    Asm = 300, AsmTypes = 302, AsmModels = 304, AsmCore = 310, AsmDecoder = 314,

    AsmTest = Asm | Test, AsmApp = Asm | App,

    Intrinsics = 70, Vectorized = 330, VData = 331, DVec = 332, GVec = 333, FVec = 334, VSvc = 75, Circuits = 720,

    IntrinsicsTest = Intrinsics | Test, VectorizedTest = Vectorized | Test,
    
    LibM = 150, LibMTest = LibM | Test,

    Matrix = 160, MatrixTest = Matrix | Test,

    Machines = 180, MachinesTest = Machines | Test,
    
    MklApi = 220, MklApiTest = MklApi | Test,

    Stats = 240, StatsTest = Stats | Test,

    Blocks = 260, BlocksTest = Blocks | Test,

    WorkflowRuntime = 270, WorkflowTest = WorkflowRuntime | Test,

    Analogs = 280, AnalogsTest = Analogs | Test,

    Dynamic = 290, DynamicTest = Dynamic | Test,
    
    Identity = 360, IdentityTest = Identity | Test,

    Cil = 390, CilTest = Cil | Test,

    Permute = 400, PermuteTest = Permute | Test,

    Polyrand = 420,

    Seed = 802, Typed = 846, Fixed = 250, Time = 350, Graphs = 370,
    
    Symbolic = 410, 

    

    Textual = 810, Collective = 804, Reflective = 808, Monadic = 806,

    Canonical = 812, 
    
    SFuncs = 816,

    Cast = 842, Memories = 814, 
    
    Custom = 818,

    Identify = 820, Kinds = 822, Api = 824,
    
    Messages = 840, Apps = 828,

    Numeric = 830, Tuples = 826,
                        
    Flow = 850, Enums = 852, Reports = 832,
    
    Core = 836,

    Checks = 848,
            
    Contained = 854,

    Z = 1024,

    TestLib = 430,

    Validity = 432,

    ValidityCore = 434,

    ValidityVectors = 436,

    ValidityTest = Validity | Test,

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

#if KindedPart

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

#endif