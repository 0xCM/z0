//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    using N = N8;

    [ApiHost]
    public class AC8 : AsciCodeApi<N8,AC8>
    {
        public static AsciCode8 Empty => new AsciCode8(0);

        public const int Length = (int)N.Value;

        [MethodImpl(Inline), Op]
        public static AsciCode8 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode8 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode8 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 define(in ulong src)
            => ref view<ulong,AsciCode8>(src);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode8 src, byte index)
            => (AsciCharCode)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode8 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode8 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            seek(dst,5) = skip(data,5);
            seek(dst,6) = skip(data,6);
            seek(dst,7) = skip(data,7);
            return 8;
        } 
        
        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode8 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src,index));

        [MethodImpl(Inline), Op]
        public static string format(AsciCode8 src)
        {
            Span<char> dst = stackalloc char[Length];
            decode(src,dst);
            return new string(dst);
        }
    }
}