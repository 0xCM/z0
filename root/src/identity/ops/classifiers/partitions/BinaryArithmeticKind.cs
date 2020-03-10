//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;
    using Id = OpKindId;

    using A = OpKindAttribute;

    /// <summary>
    /// Classsifies binary arithmetic operators
    /// </summary>
    public enum BinaryArithmeticKind : ulong
    {
        None = 0,

        Add = Id.Add,

        Sub = Id.Sub,

        Mul = Id.Mul,

        Div = Id.Div,

        Mod = Id.Mod,

        Clamp = Id.Clamp,
    }    

    public sealed class SubAttribute : A { public SubAttribute() : base(Sub) {} }

    public sealed class MulAttribute : A { public MulAttribute() : base(Mul) {} }

    public sealed class DivAttribute : A { public DivAttribute() : base(Div) {} }
        
    public sealed class ModAttribute : A { public ModAttribute() : base(Mod) {} }

    public sealed class ClampAttribute : A { public ClampAttribute() : base(Clamp) {} }


    partial class ClassifierFormat
    {
        [MethodImpl(Inline)]
        public static string Format(this BinaryArithmeticKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}