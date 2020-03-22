//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using W = TypeWidthKind;

    public enum TypeWidthKind : ushort
    {
        /// <summary>
        /// Indicates the width is not fixed or is unknown
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a bit-width of 1
        /// </summary>
        W1 = 1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = 8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = 16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = 32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = 64,

        /// <summary>
        /// Indicates a bit-width of 128
        /// </summary>
        W128 = 128,

        /// <summary>
        /// Indicates a bit-width of 256
        /// </summary>
        W256 = 256,

        /// <summary>
        /// Indicates a bit-width of 512
        /// </summary>
        W512 = 512,
    }

    public interface ITypeWidthKind : IEnumeratedKind<TypeWidthKind>, IFixedWidth
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)Class;
    }

    public interface ITypeWidthKind<K> : ITypeWidthKind, IEnumeratedKind<K, TypeWidthKind>
        where K : struct, ITypeWidthKind<K>
    {
    }

    public readonly struct TypeWidth<T> : ITypeWidthKind<TypeWidth<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TypeWidthKind(TypeWidth<T> src)
            => src.Class;

        public TypeWidthKind Class 
        {
            [MethodImpl(Inline)]
            get => (TypeWidthKind)(Unsafe.SizeOf<T>() *8);            
        }
    }

    public readonly struct TypeWidth<K,T>
        where T : unmanaged
        where K : struct, ITypeWidthKind<K>
    {
        public K Kind => default;        

        public TypeWidthKind Class { [MethodImpl(Inline)] get => Kind.Class; }
    }

    public static class TypeWidths
    {        
        public readonly struct W1 : ITypeWidthKind<W1> { public TypeWidthKind Class => W.W1; }

        public readonly struct W8 : ITypeWidthKind<W8> { public TypeWidthKind Class => W.W8; }

        public readonly struct W16 : ITypeWidthKind<W16> { public TypeWidthKind Class => W.W16; }

        public readonly struct W32 : ITypeWidthKind<W32> { public TypeWidthKind Class => W.W32; }

        public readonly struct W64 : ITypeWidthKind<W64> { public TypeWidthKind Class => W.W64; }

        public readonly struct W128 : ITypeWidthKind<W128> { public TypeWidthKind Class => W.W128; }

        public readonly struct W256 : ITypeWidthKind<W256> { public TypeWidthKind Class => W.W256; }

        public readonly struct W512 : ITypeWidthKind<W512> { public TypeWidthKind Class => W.W512; }

        public static W1 w1 => default(W1);

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        [MethodImpl(Inline)]
        public static TypeWidth<T> width<T>()        
            where T : unmanaged
                => default(TypeWidth<T>);
    }
}