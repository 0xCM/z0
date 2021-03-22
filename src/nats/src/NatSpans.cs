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
    public readonly struct NatSpans
    {
        [MethodImpl(Inline)]
        public static void fill<N,T>(in NatSpan<N,T> dst, T data)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.broadcast(data, dst);

        /// <summary>
        /// Clones a natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static NatSpan<N,T> replicate<N,T>(in NatSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> dst = new T[TypeNats.value<N>()];
            copy(src, dst);
            return new NatSpan<N,T>(dst);
        }

        [MethodImpl(Inline)]
        public static Span<T> slice<N,T>(in NatSpan<N,T> src, int offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Edit.Slice(offset);

        [MethodImpl(Inline)]
        public static Span<T> slice<N,T>(in NatSpan<N,T> src, int offset, int length)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Edit.Slice(offset, length);

        [MethodImpl(Inline)]
        public static void copy<N,T>(in NatSpan<N,T> src, Span<T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Edit.CopyTo(dst);

        [MethodImpl(Inline), Op]
        public static uint hash(NatSpanSig src)
            => (((uint)(ushort)src.Length) | ((uint)src.CellWidth) << 16) | ((uint)src.Indicator << 28);

        [MethodImpl(Inline), Op]
        public static bool eq(NatSpanSig a, NatSpanSig b)
            => @as<NatSpanSig,ulong>(a) == @as<NatSpanSig,ulong>(b);

        [Op]
        public static string format(NatSpanSig src)
            => text.concat(IDI.Nat, src.Length.ToString(), IDI.SegSep, src.CellWidth.ToString(), src.Indicator);

        [MethodImpl(Inline), Op]
        public static NatSpanSig sig(uint length, ushort cellwidth, AsciChar indicator)
            => new NatSpanSig(length, cellwidth, indicator);

        [Op]
        public static ParseResult<NatSpanSig> sig(string src)
        {
            var parts = src.Split(IDI.SegSep);
            var fail = root.unparsed<NatSpanSig>(src);
            if(parts.Length == 2)
            {
                var part1 = parts[0];
                var part2 = parts[1];
                var n = z32;
                var w = z16;
                var indicator = AsciChar.Null;
                if(part1[0] == IDI.Nat)
                {
                    var number =  part1.TakeAfter(IDI.Nat);
                    uint.TryParse(number, out n);

                    var digits = string.Empty;
                    foreach(var c in part2)
                    {
                        if(Char.IsDigit(c))
                            digits += c;
                        else
                        {
                            indicator = (AsciChar)c;
                            break;
                        }
                    }

                    if(digits.IsNotBlank())
                        ushort.TryParse(digits, out w);
                }

                if(n != 0 && w != 0 && indicator != AsciChar.Null)
                    return root.parsed(src, sig(n, w, indicator));
                else
                    return fail;
            }
            else
                return fail;
        }
    }
}