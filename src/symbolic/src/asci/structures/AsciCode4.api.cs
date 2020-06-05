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

    using N = N4;    

    [ApiHost]
    public class AC4 : AsciCodeApi<N4,AC4>
    {
        public const int Length = (int)N.Value;

        public static AsciCode4 Empty => new AsciCode4(0);

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode4 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode4 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode4 src, byte index)
            => (AsciCharCode)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static char decode(AsciCode4 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(AsciCodeCover a, AsciCodeCover b, AsciCodeCover c, AsciCodeCover d)
        {
            var x0 = (uint)a;
            var x1 = (uint)((uint)b << 8);
            var x2 = (uint)((uint)c << 16);
            var x3 = (uint)((uint)d << 24);
            return new AsciCode4(x0 | x1 | x2 | x3);
        }

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 define(in uint src)
            => ref view<uint,AsciCode4>(src);

        [MethodImpl(Inline), Op]
        public static int decode(AsciCode4 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 

        [MethodImpl(Inline), Op]
        public static AsciCode4 encode(string src)
        {
            var dst = 0u;
            var data = span(src);
            ref readonly var src16 = ref head(data);
            ref var dst8 = ref imagine<uint,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            return define(dst);
        }

        /// <summary>
        /// Populates a 4-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 encode(ReadOnlySpan<char> src, out AsciCode4 dst)
        {
            dst = default;
            Symbolic.literals(src, Control.span<AsciCode4,AsciCharCode>(ref dst));
            return ref dst;
        }
        
        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode4 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src,index));

        [MethodImpl(Inline), Op]
        public static string format(AsciCode4 src)
        {
            Span<char> dst = stackalloc char[Length];
            decode(src,dst);
            return new string(dst);
        }
    }
}