//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiKeyId;

    /// <summary>
    /// Identifies binary arithmetic operators classes
    /// </summary>
    public enum BinaryArithmeticApiKey : ushort
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

        Dist = Id.Dist,

        ClMul = Id.ClMul,

        Dot = Id.Dot,

        // Inc = Id.Inc,

        // Dec = Id.Dec,

        // Negate = Id.Negate,

        // Abs = Id.Abs,

        // Square = Id.Square,

        // Sqrt = Id.Sqrt,


        Fma = Id.Fma,

        ModMul = Id.ModMul
    }
}