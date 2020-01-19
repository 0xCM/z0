//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    [Flags]
    public enum CodeFacets : ulong
    {
        None = 0,

        Const = Pow2.T00,

        Static = Pow2.T01,

        Public = Pow2.T10,

        Private = Pow2.T11,

        Protected = Pow2.T12,

        Internal = Pow2.T13,
    }

    [Flags]
    public enum TypeFacets : ulong
    {
        None = CodeFacets.None,

        Const = CodeFacets.Const,

        Static = CodeFacets.Static,

        Public = CodeFacets.Public,

        Private = CodeFacets.Private,

        Protected = CodeFacets.Protected,

        Internal = CodeFacets.Internal,

    }

    [Flags]
    public enum MemberFacets : ulong
    {
        None = CodeFacets.None,

        Const = CodeFacets.Const,

        Static = CodeFacets.Static,

        Public = CodeFacets.Public,

        Private = CodeFacets.Private,

        Protected = CodeFacets.Protected,

        Internal = CodeFacets.Internal,

    }

    [Flags]
    public enum FieldFacets : ulong
    {
        None = CodeFacets.None,

        Const = CodeFacets.Const,

        Static = CodeFacets.Static,

        Public = CodeFacets.Public,

        Private = CodeFacets.Private,

        Protected = CodeFacets.Protected,

        Internal = CodeFacets.Internal,
    }

    [Flags]
    public enum StructFacets : ulong
    {
        None = CodeFacets.None,

        Const = CodeFacets.Const,

        Static = CodeFacets.Static,

        Public = CodeFacets.Public,

        Private = CodeFacets.Private,

        Protected = CodeFacets.Protected,

        Internal = CodeFacets.Internal,

    }

    [Flags]
    public enum ClassFacets : ulong
    {
        None = CodeFacets.None,

        Public = CodeFacets.Public,

        Static = CodeFacets.Static,

        Private = CodeFacets.Private,

        Protected = CodeFacets.Protected,

        Internal = CodeFacets.Internal,

    }
}