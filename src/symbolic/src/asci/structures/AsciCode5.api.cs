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

    using N = N5;    
    using A = AsciCharCode;
    using C = AsciCode;

    [ApiHost]
    public class AC5 : AsciCodeApi<N5,AC5>
    {
        public const int Length = (int)N.Value;

        public static AsciCode5 Empty => new AsciCode5(0);

        [MethodImpl(Inline), Op]
        public static C code(AsciCode5 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode5 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static void chars(AsciCode5 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
        } 

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode5 define(in ulong src)
            => ref view<ulong,AsciCode5>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode5 define(string src)
        {
            var dst = 0ul;
            var data = span(src);
            ref readonly var src16 = ref head(data);
            ref var dst8 = ref imagine<ulong,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            seek(ref dst8, 4) = (byte)skip(src16, 4);
            return define(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsciCode5 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,ulong>(src)));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode5 fill(ReadOnlySpan<char> src, out AsciCode5 dst)
        {
            dst = default;
            Symbolic.literals(src, Control.span<AsciCode5,A>(ref dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode5 src)
        {
            Span<char> dst = stackalloc char[Length];
            chars(src,dst);
            return new string(dst);
        }
    }
}