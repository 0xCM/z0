//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    using N = N2;
    using A = AsciCharCode;
    using C = AsciCode;

    [ApiHost]
    public class AC2 : AsciCodeApi<N2,AC2>
    {
        public static AsciCode2 Empty => new AsciCode2(0);

        public const int Length = (int)N.Value;        

        [MethodImpl(Inline), Op]
        public static AsciCode2 define(C a, C b)
        {
            var x0 = (ushort)a;
            var x1 = (ushort)((ushort)b << 8);
            return new AsciCode2((ushort)(x0 | x1));
        }

        [MethodImpl(Inline), Op]
        public static AsciCode2 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode2 define(in ushort src)
            => ref view<ushort,AsciCode2>(src);

        [MethodImpl(Inline), Op]
        public static A kind(AsciCode2 src, byte index)
            => (A)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode2 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static C code(AsciCode2 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode2 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode2 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode2 src, byte index)
            => (char)kind(src,index);

        /// <summary>
        /// Populates a 4-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode2 fill(ReadOnlySpan<char> src, out AsciCode2 dst)
        {
            dst = default;
            Symbolic.literals(src, Control.span<AsciCode2,A>(ref dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void chars(AsciCode2 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
        } 

        [MethodImpl(Inline), Op]
        public static string format(AsciCode2 src)
        {
            Span<char> dst = stackalloc char[Length];
            chars(src,dst);
            return new string(dst);
        }
    }
}