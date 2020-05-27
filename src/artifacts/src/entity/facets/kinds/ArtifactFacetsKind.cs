//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2Kind;

    using PNK = PrimalNumericKind;
    using AF = ArtifactFacetKind;

    public enum ModifierFacetKind : ulong
    {
        /// <summary>
        /// Member is const
        /// </summary>    
        Const = AF.Const,

        /// <summary>
        /// Type or member is static
        /// </summary>    
        Static = AF.Static,

    }

    [Flags]
    public enum ArtifactFacetKind : ulong
    {
        None = 0,

        U8 = PNK.U8,

        U16 = PNK.U16,

        U32 = PNK.U32,

        U64 = PNK.U64,

        I8 = PNK.U8,

        I16 = PNK.I16,

        I32 = PNK.I32,

        I64 = PNK.I64,

        F32 = PNK.F32,

        F64 = PNK.F64,

        /// <summary>
        /// Member is const
        /// </summary>    
        Const = P2ᐞ05,

        /// <summary>
        /// Type or member is static
        /// </summary>    
        Static = P2ᐞ06,

        /// <summary>
        /// Member is non-static
        /// </summary>    
        Instance = P2ᐞ07,

        /// <summary>
        /// Access to target is unrestricted
        /// </summary>    
        Public = P2ᐞ10,

        /// <summary>
        /// Target is accessible from the containing type
        /// </summary>    
        Private = P2ᐞ11,

        /// <summary>
        /// Target is accessible from the declaring type or subtypes
        /// </summary>    
        Protected = P2ᐞ12,

        /// <summary>
        /// Target is accessible from the declaring assembly
        /// </summary>    
        Internal = P2ᐞ13,

        /// <summary>
        /// Target is accessible from the current assembly or from types that are derived from the containing class
        /// </summary>    
        ProtectedInternal = Protected | Internal,

        /// <summary>
        /// Target is accessible from the containing class or types derived from the containing class within the current assembly
        /// </summary>    
        PrivateProtected = Private | Protected,
    }
}