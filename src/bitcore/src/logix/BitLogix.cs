//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;    
    using static TernaryLogicKind;

    using BLK = BinaryLogicKind;
    using TLK = TernaryLogicKind;
    using ULK = UnaryLogicKind;

    using K = Kinds;

    /// <summary>
    /// Defines logical operations over 1, 2 or 3 bits
    /// </summary>
    [ApiHost]
    public readonly partial struct BitLogix : IApiHost<BitLogix>, IBitLogix
    {        
        public static BitLogix Service => default(BitLogix);
        
        [MethodImpl(Inline)]
        public bit Evaluate<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
                => BitLogixOps.eval(a, b, kind);

        [MethodImpl(Inline), Op]
        public bit Nand_kind(bit a, bit b)        
            => BitLogixOps.eval(a, b, K.nand());

        [MethodImpl(Inline), Op]
        public bit Xor_kind(bit a, bit b)        
            => BitLogixOps.eval(a, b, K.xor());

        /// <summary>
        /// Advertises the supported unary opeators
        /// </summary>
        public ReadOnlySpan<ULK> UnaryOpKinds
            => Enums.valarray<ULK>();

        /// <summary>
        /// Advertises the supported binary opeators
        /// </summary>
        public ReadOnlySpan<BLK> BinaryOpKinds
            => Enums.valarray<BLK>();
         
        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public ReadOnlySpan<TLK> TernaryOpKinds
            => gmath.range((byte)1,(byte)TLK.X5F).Cast<TLK>().ToArray();

        /// <summary>
        /// Returns a kind-indentified unary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public UnaryOp<bit> Lookup(ULK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Returns a kind-indentified binary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public BinaryOp<bit> Lookup(BLK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Returns a kind-indentified ternary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        [MethodImpl(Inline)]
        public TernaryOp<bit> Lookup(TLK kind)
            => BitLogixOps.lookup(kind);

        /// <summary>
        /// Evaluates a unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operaor kind</param>
        /// <param name="a">The operand</param>        
        [MethodImpl(Inline)]
        public bit Evaluate(ULK kind, bit a)
            => BitLogixOps.eval(kind,a);

        /// <summary>
        /// Evaluates a bianry operator over supplied operands
        /// </summary>
        /// <param name="kind">The operaor kind</param>
        /// <param name="a">The operand</param>        
        [MethodImpl(Inline)]
        public bit Evaluate(BLK kind, bit a, bit b)
            => BitLogixOps.eval(kind, a, b);

        /// <summary>
        /// Evaluates a ternary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operaor kind</param>
        /// <param name="a">The operand</param>        
        [MethodImpl(Inline)]
        public bit Evaluate(TLK kind, bit a, bit b, bit c)
            => BitLogixOps.eval(kind, a, b, c);
    }
}