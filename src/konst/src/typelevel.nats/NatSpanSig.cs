//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using NI = NumericIndicator;

    partial class XTend
    {
        public static Option<NumericIndicator> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i != 0 ? Option.some(i) : Option.none<NumericIndicator>();
        }           
    }
    
    public readonly struct NatSpanSig : IEquatable<NatSpanSig>
    {
        public static Option<NatSpanSig> From(Type t)
            => from def in t.GenericDefinition() 
                where def == typeof(NatSpan<,>) && t.IsClosedGeneric()
                let args = t.SuppliedTypeArgs().ToArray()
                let pair = (nat: args[0], cell: args[1])
                let w = (int)pair.cell.NumericWidth()
                from n in pair.nat.NatValue()
                from i in pair.cell.NumericIndicator()
                select Define((int)n, w, i.ToChar());

        public static Option<NatSpanSig> Parse(string src)
        {
            var parts = src.Split(IDI.SegSep);
            if(parts.Length == 2)
            {
                var part1 = parts[0];
                var part2 = parts[1];
                var n = ulong.MaxValue;
                var w = int.MaxValue;                
                var indicator = Chars.Question;
                if(part1[0] == IDI.Nat)
                {
                    var number =  part1.TakeAfter(IDI.Nat);
                    ulong.TryParse(number, out n);
                    
                    var digits = string.Empty;
                    foreach(var c in part2)
                    {
                        if(Char.IsDigit(c))
                            digits += c;
                        else
                        {
                            indicator = c;
                            break;
                        }
                    }
                    
                    if(digits.IsNotBlank())
                        int.TryParse(digits, out w);                    
                }         
                     
                if(n != ulong.MaxValue && w != int.MaxValue && indicator != Chars.Question) 
                    return NatSpanSig.Define((int)n, w, indicator);
                else 
                    return default;             
            }
            else
                return default;
        }

        public static NatSpanSig Define(int length, int cellwidth, char indicator)
            => new NatSpanSig(length, cellwidth, indicator);

        public NatSpanSig(int length, int cellwidth, char indicator)
        {
            Length = length;
            CellWidth = cellwidth;
            Indicator = indicator;
        }

        public readonly int Length;
        
        public readonly int CellWidth;

        public readonly char Indicator;

        public override int GetHashCode()
            => HashCode.Combine(Length,CellWidth,Indicator);
        
        public bool Equals(NatSpanSig src)
            => Length == src.Length && CellWidth == src.CellWidth && Indicator == src.Indicator;
        
        public override bool Equals(object obj)
            => obj is NatSpanSig s && Equals(s);
        
        public override string ToString()
            => text.concat(IDI.Nat, Length.ToString(), IDI.SegSep, CellWidth.ToString(), Indicator);
    }
}