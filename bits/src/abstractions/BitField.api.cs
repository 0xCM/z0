//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public static class BitField
    {
        public static BitFieldSpec specify(params (ushort first, ushort last)[] positions)
        {
            var fields = new SegmentSpec[positions.Length];
            for(var i=0; i<fields.Length; i++)
                fields[i] = positions[i];
            return new BitFieldSpec(fields);
        }       

        [MethodImpl(Inline)]
        public static BitField64 init(ulong data, BitFieldSpec spec)
            => new BitField64(data, spec);

        [MethodImpl(Inline)]
        public static BitField64 init(ulong data, params SegmentSpec[] fields)
            => new BitField64(data, fields);

        static BitField256<E> define<E>(params Pair<E,byte>[] parts)
            where E : unmanaged, Enum
        {
            var widths = default(Vector256<byte>);
            for(var i=0; i<parts.Length; i++)
                setwidth(widths, parts[i]);
            return new BitField256<E>(widths);
        }

        static Span<Pair<E,byte>> parts<E>(BitField256<E> bf)
            where E : unmanaged, Enum
        {
            Span<Pair<E,byte>> parts = new Pair<E,byte>[32];
            var data = bf.widths.ToSpan();

            var count = 0;
            for(int i=0; i < data.Length; i++)
            {
                var mask = data[i];
                if(mask != 0)
                    parts[count++] = paired<E,byte>(emember<E,byte>((byte)i), (byte)Bits.width(mask));
            }
            return parts.Slice(0,count);
        }

        static string format<E>(BitField256<E> bf)
            where E : unmanaged, Enum
        {
            var pairs = parts(bf);
            
            var fmt = text();            
            for(var i=0; i < pairs.Length; i++)
            {
                var part = pairs[i];
                fmt.Append($"{part.A}:{part.B}");
                if(i != pairs.Length - 1)
                {
                    fmt.Append(AsciSym.Comma);
                    fmt.Append(AsciSym.Space);
                }
            }
            return embrace(fmt.ToString());
        }

        [MethodImpl(Inline)]
        static Vector128<T> filter<E,T>(BitField256<E> bf, Vector128<T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => vgeneric<T>(dinx.vand(v8u(src), dinx.vlo(bf.widths)));

        [MethodImpl(Inline)]
        static Vector256<T> filter<E,T>(BitField256<E> bf, Vector256<T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => vgeneric<T>(dinx.vand(v8u(src), bf.widths));

        const byte MaxFieldWidth = 7;

        [MethodImpl(Inline)]
        internal static Vector256<byte> setwidth<E>(Vector256<byte> widths, Pair<E,byte> spec)
            where E : unmanaged, Enum
            => widths = widths.WithElement(eint(spec.A), BitMask.lomask<byte>(math.clamp(spec.B,MaxFieldWidth)));

        [MethodImpl(Inline)]
        internal static byte getwidth<E>(Vector256<byte> widths, E field)
            where E : unmanaged, Enum
                => (byte)Bits.width(widths.GetElement(eint(field)));

    }
}