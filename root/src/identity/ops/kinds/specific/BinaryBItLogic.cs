//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using K = BinaryBitLogicKind;

    /// <summary>
    /// Classifies binary boolean and bitwise logical operations
    /// </summary>
    public enum BinaryBitLogicKind : byte
    {         
        /// <summary>
        /// Classifies a logical  binary operator false(a,b) := bv(0000)
        /// </summary>
        /// <remarks>
        /// bv(0000) = id(True)
        /// </remarks>
        False = 0b0000,

        /// <summary>
        /// Classifies a logical binary operator and(a,b) := bv(1000)
        /// </summary>
        /// <remarks>
        /// bv(1000) = id(Nor)
        /// 0 0 0
        /// 1 0 0
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        And = 0b0001,

        /// <summary>
        /// Classifies a logical binary operator cnotimply(a,b) := and(a, ~b) = bv(0010)
        /// </summary>
        /// <remarks>
        /// bv(0010) = id(ConverseNonimplication)
        /// Truth table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        CNonImpl = 0b0010,               

        /// <summary>
        /// Classifes a logical binary operator left(a,b) := a = bv(1010)
        /// </summary>
        /// <remarks>
        /// bv(1010) = id(RightNot)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        LProject = 0b0011, 

        /// <summary>
        /// Identifies a logical binary operator notimply(a,b) := and(~a, b) = bv(0100)
        /// </summary>
        /// <remarks>
        /// bv(0100) = id(Nonimplication)
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        NonImpl = 0b0100,        

        /// <summary>
        /// Classifies a logical binary operator right(a,b) := b = bv(1100)
        /// </summary>
        /// <remarks>
        /// bv(1100) = id(LeftNot)
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        RProject = 0b0101,

        /// <summary>
        /// Classifies a logical binary operator xor(a,b) := bv(0110)
        /// </summary>
        /// <remarks>
        /// bv(0110) = id(XOr)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        Xor = 0b0110,

        /// <summary>
        /// Classifies a logical binary operator or(a,b) := bv(1110)
        /// </summary>
        /// <remarks>
        /// bv(1110) = id(Nand)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        Or = 0b0111,

        /// <summary>
        /// Classifies a logical binary operator that computes nor(a,b) := not(or(a,b)) = bv(0001)
        /// </summary>
        /// <remarks>
        /// bv(0001) = id(And)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        Nor = 0b1000, 

        /// <summary>
        /// Classifies a binary operator xnor(a,b) := not(xor(a,b)) = bv(1001)
        /// </summary>
        /// <remarks>
        /// bv(1001) = id(Xnor)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        Xnor = 0b1001, 

        /// <summary>
        /// Classifes a logical binary operator rnot(a,b) := not(b) = bv(0011)
        /// </summary>
        /// <remarks>
        /// bv(0011) = id(LeftProject)
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        RNot = 0b1010, 

        /// <summary>
        /// Classifies a logical binary operator imply(a,b) := or(a, not(b)) = bv(1011)
        /// </summary>
        /// <remarks>
        /// bv(1011) = id(Implication)
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        Impl = 0b1011,

        /// <summary>
        /// Classifies a logical binary operator lnot(a,b) := not(a) = bv(0101)
        /// </summary>
        /// <remarks>
        /// bv(0101) = id(RightProject)
        /// Truth table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        LNot = 0b1100, 

        /// <summary>
        /// Classifies a logical binary operator cimply(a,b) := or(not(a), b) = bv(1101)
        /// </summary>
        /// bv(1101) = id(ConverseImplication)
        /// <remarks>
        /// Truth table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        CImpl = 0b1101,

        /// <summary>
        /// Classifies a logical binary operator nand(a,b) := not(and(a,b)) = bv(0111)
        /// </summary>
        /// <remarks>
        /// bv(0111) = id(Or)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        Nand = 0b1110, 
        
        /// <summary>
        /// Classifies a logical binary operator true(a,b) = bv(1111)
        /// </summary>
        /// <remarks>
        /// bv(1111) = id(False)
        /// </remarks>
        True = 0b1111,
    } 

    /// <summary>
    /// Characterizes a type that represents an operation kind
    /// </summary>
    public interface IBitLogicKind
    {
        string Name {get;}
    }

    public interface IBitLogicKind<K,E> : IBitLogicKind
        where E : unmanaged, Enum
        where K : unmanaged, IBitLogicKind<K,E>
    {        
        E Kind {get;}

        string IBitLogicKind.Name => Kind.ToString().ToLower();        
        
    }   

    partial class BitLogicKinds
    {
        public readonly struct And : IBitLogicKind<And,K> { public K Kind { [MethodImpl(Inline)] get => K.And;}}

        public readonly struct Or : IBitLogicKind<Or,K> { public K Kind { [MethodImpl(Inline)] get => K.Or;}}

        public readonly struct Xor : IBitLogicKind<Xor,K> { public K Kind { [MethodImpl(Inline)] get => K.Xor;}}

        public readonly struct Nand : IBitLogicKind<Nand,K> { public K Kind { [MethodImpl(Inline)] get => K.Nand;}}

        public readonly struct Nor : IBitLogicKind<Nor,K> { public K Kind { [MethodImpl(Inline)] get => K.Nor;}}

        public readonly struct Xnor : IBitLogicKind<Xnor,K> { public K Kind { [MethodImpl(Inline)] get => K.Xnor;}}

        public readonly struct Impl : IBitLogicKind<Impl,K> { public K Kind { [MethodImpl(Inline)] get => K.Impl;}}

        public readonly struct NonImpl : IBitLogicKind<NonImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.NonImpl;}}

        public readonly struct CImpl : IBitLogicKind<CImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.CImpl;}}

        public readonly struct CNonImpl : IBitLogicKind<CNonImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.CNonImpl;}}

        public readonly struct Not : IBitLogicKind<Not,UnaryBitLogicKind> { public UnaryBitLogicKind Kind { [MethodImpl(Inline)] get => UnaryBitLogicKind.Not;}}

    }

    partial class ClassifierFormat
    {
        [MethodImpl(Inline)]
        public static string Format(this BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }    
}