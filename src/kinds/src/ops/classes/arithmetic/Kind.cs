//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    public interface IArithmeticKind : IOpKind, IOpKind<ArithmeticKind>
    {
        ArithmeticKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface IArithmeticKind<K> : IArithmeticKind, IOpKind<K,ArithmeticKind>
        where K : unmanaged, IArithmeticKind
    {
        OpKindId IOpKind.KindId => default(K).KindId;                
    }
    
    public interface IArithmeticKind<K,T> : IArithmeticKind<K>
        where K : unmanaged, IArithmeticKind
        where T : unmanaged
    {
        ArithmeticKind IArithmeticKind.Kind => default(K).Kind;
    }

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

        Dist = Id.Dist,

        ClMul = Id.ClMul,

        Dot = Id.Dot,

        Inc = Id.Inc,

        Dec = Id.Dec,

        Negate = Id.Negate,

        Abs = Id.Abs,

        Square = Id.Square,

        Sqrt = Id.Sqrt,        


        Fma = Id.Fma,

        ModMul = Id.ModMul,

        Avgz = Id.Avgz,

        Avgi = Id.Avgz,

        Max = Id.Max,

        Min = Id.Min,      
    }    
}