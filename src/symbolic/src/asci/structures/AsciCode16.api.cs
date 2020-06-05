//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Seed;
    using static Typed;
    using static Control;

    using N = N16;

    [ApiHost]
    public class AC16 : AsciCodeApi<N8,AC16>
    {
        public const int Length = (int)N.Value;

        public static AsciCode16 Blank => init(AsciCharCode.Space);
        
        public static AsciCode16 Null => new AsciCode16(Vector128<byte>.Zero);

        [MethodImpl(Inline), Op]
        public static AsciCode16 define(ulong lo, ulong hi)
            => new AsciCode16(Vector128.Create(lo,hi).AsByte());

        [MethodImpl(Inline)]
        public static AsciCode16 init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode16(SymBits.vbroadcast(w128, (byte)fill));

        public static AsciCode16[] alloc(int count)
        {
            var dst = new AsciCode16[count];
            Span<AsciCode16> x = dst;
            x.Fill(Blank);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode16 src, byte index)
            => (AsciCodeCover)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in AsciCode16 src)
            => cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode16 src, byte index)
            => (AsciCharCode)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in AsciCode16 src)
            => cast<AsciCharCode>(bytespan(src)); 
        
        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode16 encode(ReadOnlySpan<char> src, out AsciCode16 dst)
        {
            dst = default;
            Symbolic.literals(src, Control.span<AsciCode16,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static AsciCode16 encode(ReadOnlySpan<char> src)
        {
            var dst = init();
            Symbolic.literals(src, Control.span<AsciCode16,AsciCharCode>(ref dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode16 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode16 src, Span<char> dst)
        {
            var data = SymBits.vinflate(src.Data);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);
            var count = 0;    
            for(var i=0; i<chars.Length; i++, count++)
            {
                ref readonly var c = ref skip(chars,i);
                if((AsciCharCode)c != AsciCharCode.Null)
                    seek(dst,i) = c;
                else
                    break;
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in AsciCode16 src)
        {
            var data = SymBits.vinflate(src.Data);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);    
            var len = chars.Length;
            for(var i=0; i<len; i++)
            {
                if((AsciCharCode)skip(chars,i) == AsciCharCode.Null)
                {
                    len = i;
                    break;
                }
            }

            return chars.Slice(0, len);
        }

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode16 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(src.Data.GetElement(index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<AsciChar,byte>> symbols(in AsciCode16 src)
            => cast<Symbol<AsciChar,byte>>(bytespan(SymBits.vinflate(src.Data)));

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode16 src)
            => new string(decode(src));

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in AsciCode16 src, ref byte dst)
            => Store(ptr(ref dst), src.Data);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in AsciCode16 src, Span<byte> dst)
            => copy(src, ref head(dst));
    }
}