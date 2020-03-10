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
    
    using A = OpKindAttribute;
    using K = UnaryArithmeticKind;

    /// <summary>
    /// Classifies unary arithmetic operators
    /// </summary>
    public enum UnaryArithmeticKind : byte
    {
        None = 0,

        Inc = 1,

        Dec = 2,

        Negate = 3,

        Abs,

        Square,

        Sqrt,
    }    

    public sealed class IncAttribute : A { public IncAttribute() : base(Inc) {} }

    public sealed class DecAttribute : A { public DecAttribute() : base(Dec) {} }

    public sealed class NegateAttribute : A { public NegateAttribute() : base(Negate) {} }

    public sealed class AbsAttribute : A { public AbsAttribute() : base(Abs) {} }

    public sealed class SquareAttribute : A { public SquareAttribute() : base(Square) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute() : base(Sqrt) {} }

    partial class OpKinds
    {
        public readonly struct Inc : IOpKind<Inc,K> { public K Kind { [MethodImpl(Inline)] get => K.Inc;}}        
        
        public readonly struct Dec : IOpKind<Dec,K> { public K Kind { [MethodImpl(Inline)] get => K.Dec;}}        

        public readonly struct Negate : IOpKind<Negate,K> { public K Kind { [MethodImpl(Inline)] get => K.Negate;}}

        public readonly struct Abs : IOpKind<Abs,K> { public K Kind { [MethodImpl(Inline)] get => K.Abs;}}

        public readonly struct Square : IOpKind<Square,K> { public K Kind { [MethodImpl(Inline)] get => K.Square;}}

        public readonly struct Sqrt : IOpKind<Sqrt,K> { public K Kind { [MethodImpl(Inline)] get => K.Sqrt;}}
    }

    partial class ClassifierFormat
    {
        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticKind kind)
            => kind switch {
                UnaryArithmeticKind.Inc => "++",
                UnaryArithmeticKind.Dec => "--",
                UnaryArithmeticKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticKind kind, T arg)
            => $"{kind.Format()}({arg})";

    }

}