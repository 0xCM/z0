//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    /// <summary>
    /// Identifies binary arithmetic operators classes
    /// </summary>
    public enum BinaryArithmeticKindId : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        Add = Id.Add,

        Sub = Id.Sub,

        Mul = Id.Mul,

        Div = Id.Div,

        Mod = Id.Mod,

        Clamp = Id.Clamp,
    }    
}