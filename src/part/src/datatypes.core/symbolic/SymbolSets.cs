//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct SymbolSets
    {
        const NumericKind Closure = UnsignedInts;

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
        /// <summary>
        /// Defines a symbol set
        /// </summary>
        /// <param name="symbols"></param>
        /// <typeparam name="S">The symbol data type</typeparam>
        /// <typeparam name="T">The symbol domain type</typeparam>
        /// <typeparam name="W">The symbol bit-width type</typeparam>
        [MethodImpl(Inline)]
        public static SymbolSet<S,T,W> create<S,T,W>(params S[] symbols)
            where S : unmanaged, ISymbol
            where T : unmanaged
            where W : unmanaged, IDataWidth
                => new SymbolSet<S,T,W>(symbols);

        [MethodImpl(Inline), Closures(Closure)]
        public static char @char<S>(Symbol<S> src)
            where S : unmanaged, IEquatable<S>
                => @as<S,char>(src.Value);

        [MethodImpl(Inline)]
        public static char @char<S,T>(Symbol<S,T> src)
            where S : unmanaged, IEquatable<S>
            where T : unmanaged
                => @as<S,char>(src.Value);

        [MethodImpl(Inline)]
        public static char @char<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged, IEquatable<S>
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => @as<S,char>(src.Value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static char render<S>(S src)
            where S : unmanaged
                => (char)@as<S,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> render<S>(Span<S> src)
            where S : unmanaged, ISymbol
        {
            var count = src.Length;
            if(count == 0)
                return default;
            else if(size<S>() == size<char>())
                return cover(@as<S,char>(first(src)), count);
            else
                return render(src, span<char>(count));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> render<S>(Span<S> src, Span<char> dst)
            where S : unmanaged, ISymbol
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = render(skip(src,i));
            return slice(dst, 0, count);
        }

        [MethodImpl(Inline)]
        public static char render<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => render<S>(src.Value);

        [MethodImpl(Inline)]
        public static char render<S,T>(Symbol<S,T> src)
            where S : unmanaged
            where T : unmanaged
                => @as<S,char>(src.Value);
    }
}