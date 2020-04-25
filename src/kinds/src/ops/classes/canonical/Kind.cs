//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = OpKindId;

    /// <summary>
    /// Classifies binary boolean and bitwise logical operations
    /// </summary>    
    public enum CanonicalKind : ulong
    {         
        None = 0,

        Reverse = Id.Reverse,

        Concat = Id.Concat,

        Identity = Id.Identity,

        Parse = Id.Parse,

        Slice = Id.Slice,

        Enable = Id.Enable,
        
        Disable = Id.Disable,

        Lo = Id.Lo,

        Hi = Id.Hi,

        Left = Id.Left,

        Right = Id.Right,

        Replicate = Id.Replicate,

        Split = Id.Split,

        Toggle = Id.Toggle,

    }   
}