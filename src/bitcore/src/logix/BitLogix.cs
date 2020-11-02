//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    using BLK = BinaryBitLogicKind;
    using TLK = TernaryBitLogicKind;
    using ULK = UnaryBitLogicKind;

    using K = BitLogicKinds;

    /// <summary>
    /// Defines logical operations over 1, 2 or 3 bits
    /// </summary>
    [ApiHost]
    public readonly partial struct BitLogix : IBitLogix
    {
        public static BitLogix Service => default(BitLogix);

        [MethodImpl(Inline)]
        public Bit32 Evaluate<F>(Bit32 a, Bit32 b, F kind = default)
            where F : unmanaged, IBitLogicKind
                => BitLogixOps.eval(a, b, kind);

        [MethodImpl(Inline), Op]
        public Bit32 Nand_kind(Bit32 a, Bit32 b)
            => BitLogixOps.eval(a, b, K.nand(n2));

        [MethodImpl(Inline), Op]
        public Bit32 Xor_kind(Bit32 a, Bit32 b)
            => BitLogixOps.eval(a, b, K.xor(n2));

        /// <summary>
        /// Advertises the supported unary operators
        /// </summary>
        public ReadOnlySpan<ULK> UnaryOpKinds
            => Enums.literals<ULK>();

        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public ReadOnlySpan<BLK> BinaryOpKinds
            => Enums.literals<BLK>();

        /// <summary>
        /// Advertises the supported ternary operators
        /// </summary>
        public ReadOnlySpan<TLK> TernaryOpKinds
            => Algorithmic.stream((byte)1,(byte)TLK.X5F).Cast<TLK>().ToArray();

        /// <summary>
        /// Returns a kind-identified unary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public UnaryOp<Bit32> Lookup(ULK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Returns a kind-identified binary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public BinaryOp<Bit32> Lookup(BLK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Returns a kind-identified ternary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public TernaryOp<Bit32> Lookup(TLK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Evaluates a unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public Bit32 Evaluate(ULK kind, Bit32 a)
            => BitLogixOps.eval(kind,a);

        /// <summary>
        /// Evaluates a binary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public Bit32 Evaluate(BLK kind, Bit32 a, Bit32 b)
            => BitLogixOps.eval(kind, a, b);

        /// <summary>
        /// Evaluates a ternary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public Bit32 Evaluate(TLK kind, Bit32 a, Bit32 b, Bit32 c)
            => BitLogixOps.eval(kind, a, b, c);
    }
}