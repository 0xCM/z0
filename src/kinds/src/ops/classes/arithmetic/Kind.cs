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
    public enum ArithmeticKind : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        Add = Id.Add,

        AddS = Id.AddS,

        AddH = Id.AddH,

        AddHS = Id.AddHS,

        Sad = Id.Sad,

        Sub = Id.Sub,

        SubH = Id.SubH,

        SubHS = Id.SubHS,

        SubS = Id.SubS,

        Mul = Id.Mul,

        MulLo = Id.MulLo,

        MulHi = Id.MulHi,

        Div = Id.Div,

        Mod = Id.Mod,

        Clamp = Id.Clamp,

        Dot = Id.Dot,

        Inc = Id.Inc,

        Dec = Id.Dec,

        Negate = Id.Negate,

        Abs = Id.Abs,

        Square = Id.Square,

        Sqrt = Id.Sqrt,        

        Avgz = Id.Avgz,

        Avgi = Id.Avgz,

        Max = Id.Max,

        Min = Id.Min,      

        Dist = Id.Dist,

        ClMul = Id.ClMul,

        Fma = Id.Fma,

        ModMul = Id.ModMul,

    }    
}