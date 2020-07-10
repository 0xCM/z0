//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using AF = ArtifactFacetKind;

    [Flags]
    public enum AccessFacetKind : ulong
    {
        None = 0,

        Public = AF.Public,

        Private = AF.Private,

        Protected = AF.Protected,

        Internal = AF.Internal,    

        ProtectedInternal = AF.ProtectedInternal,
        
        PrivateProtected = AF.PrivateProtected,    
    }
}