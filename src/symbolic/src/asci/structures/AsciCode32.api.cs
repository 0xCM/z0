//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Typed;
    using static Control;
    
    using N = N32;
    
    [ApiHost]
    public class AC32 : AsciCodeApi<N32,AC32>
    {
        public static AsciCode32 Blank => init(AsciCharCode.Space);

        public static AsciCode32 Null => new AsciCode32(Vector256<byte>.Zero);

        public const int Length = (int)N.Value;

        [MethodImpl(Inline)]
        public static AsciCode32 init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode32(SymBits.vbroadcast(w256, (byte)fill));

        public static ArraySpan<AsciCode32> alloc(int count)
        {
            ArraySpan<AsciCode32> dst = new AsciCode32[count];
            dst.Fill(Blank);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in AsciCode32 src)
        {            
            var lo = SymBits.vinflate(Vector256.GetLower(src.Data));
            var hi = SymBits.vinflate(Vector256.GetUpper(src.Data));
            var data = new Seg512(lo,hi);
            return cast<char>(Control.bytespan(data));
        }

        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static AsciCode32 encode(ReadOnlySpan<char> src)
        {
            var dst = init();
            Symbolic.literals(src, Control.span<AsciCode32,AsciCharCode>(ref dst));
            return dst;
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                this.Lo = lo;
                this.Hi = hi;
            }
        }

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(in AsciCode32 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(src.Data.GetElement(index));

        [MethodImpl(Inline), Op]
        public static string format(AsciCode32 src)
            => new string(decode(src));
    }
}