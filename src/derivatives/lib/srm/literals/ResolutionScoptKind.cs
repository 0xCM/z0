//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    public enum ResolutionScopeKind : byte
    {
        Module = 0x00000000,

        ModuleRef = 0x00000001,

        AssemblyRef = 0x00000002,

        TypeRef = 0x00000003,
    }

}