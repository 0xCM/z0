//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using Id = OpKindId;

    /// <summary>
    /// Identifies binary arithmetic operators classes
    /// </summary>
    public enum BinaryArithmeticKind : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        Add = Id.Add,

        AddS = Id.AddS,

        AddH = Id.AddH,

        AddHS = Id.AddHS,

        Sub = Id.Sub,

        SubH = Id.SubH,

        Mul = Id.Mul,

        Div = Id.Div,

        Mod = Id.Mod,

        Clamp = Id.Clamp,

        Distance = Id.Distance,

        Dot = Id.Dot,
    }    
}