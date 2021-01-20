//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using BF = BinarySymFacet;

    partial struct Symbolic
    {
        /// <summary>
        /// Creates a symbol from a <see cref='BinaryDigit'/> source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BF.First));

        /// <summary>
        /// Creates a symbol from a <see cref='OctalDigit'/> source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Symbol<OctalSym,byte,N3> symbol(OctalDigit src)
            => symbol<OctalSym,byte,N3>((OctalSym)((byte)src + (byte)OctalSym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BF.First));

        [MethodImpl(Inline), Op]
        public static Symbol<DecimalSym,byte,N4> symbol(DecimalDigit src)
            => symbol<DecimalSym,byte,N4>((DecimalSym)((byte)src + DecimalSymFacet.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(((HexSym)Asci.code(@case, src)));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => symbol<HexSym,byte,N4>(((HexSym)Asci.code(@case, src)));

        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Symbol<S> symbol<S>(S src)
            where S : unmanaged
                => new Symbol<S>(src);

        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T> symbol<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(src);

        /// <summary>
        /// Defines an <typeparamref name='S'/>-valued symbol of representation bit-width <typeparamref name='N'/>  covered by a <see cref='T'/> storage cell
        /// </summary>
        /// <param name="value">The symbol value</param>
        /// <typeparam name="S">The symbol type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        /// <typeparam name="N">The symbol representation bit-width</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T,N> symbol<S,T,N>(S value)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);
    }
}