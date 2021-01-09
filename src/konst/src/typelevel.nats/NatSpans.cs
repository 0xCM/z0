//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static z;

    using NI = NumericIndicators;

    [ApiHost]
    public readonly struct NatSpans
    {
        [MethodImpl(Inline), Op]
        public static uint hash(NatSpanSig src)
            => (((uint)(ushort)src.Length) | ((uint)src.CellWidth) << 16) | ((uint)src.Indicator << 28);

        [MethodImpl(Inline), Op]
        public static bool eq(NatSpanSig a, NatSpanSig b)
            => @as<NatSpanSig,ulong>(a) == @as<NatSpanSig,ulong>(b);

        [Op]
        public static string format(NatSpanSig src)
            => text.concat(IDI.Nat, src.Length.ToString(), IDI.SegSep, src.CellWidth.ToString(), src.Indicator);

        [Op]
        public static Option<NatSpanSig> sig(Type t)
            => from def in some(t.GenericDefinition2())
                where def == typeof(NatSpan<,>) && t.IsClosedGeneric()
                let args = t.SuppliedTypeArgs().ToArray()
                let pair = (nat: args[0], cell: args[1])
                let w = (ushort)pair.cell.NumericWidth()
                from n in pair.nat.NatValue()
                let cell = pair.cell
                let i = NI.@from(cell)
                where i != 0
                select sig((uint)n, w, (AsciChar)i.ToChar());

        [MethodImpl(Inline), Op]
        public static NatSpanSig sig(uint length, ushort cellwidth, AsciChar indicator)
            => new NatSpanSig(length, cellwidth, indicator);

        [Op]
        public static ParseResult<NatSpanSig> sig(string src)
        {
            var parts = src.Split(IDI.SegSep);
            var fail = unparsed<NatSpanSig>(src);
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
                    return parsed(src, sig(n, w, indicator));
                else
                    return fail;
            }
            else
                return fail;
        }
    }
}