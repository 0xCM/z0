//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class NatSpanType
    {
        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<NatSpanSig> signature(Type t)
            => from def in t.GenericDefinition() 
                where def == typeof(NatSpan<,>) && t.IsConstructed()
                let args = t.GenericArguments().ToArray()
                let pair = (nat: args[0], cell: args[1])
                from n in NatType.value(pair.nat)
                from w in DataTypes.width(pair.cell)
                from i in DataTypes.indicator(pair.cell)
                select NatSpanSig.Define((int)n, w, i);

        //n4x32u
        public static Option<NatSpanSig> signature(string src)
        {
            var parts = src.Split(Moniker.SegSep);
            if(parts.Length == 2)
            {
                var part1 = parts[0];
                var part2 = parts[1];
                var n = ulong.MaxValue;
                var w = int.MaxValue;                
                var indicator = AsciSym.Question;
                if(part1[0] == Moniker.NatIndicator)
                {
                    var number =  part1.TakeAfter(Moniker.NatIndicator);
                    ulong.TryParse(number, out n);
                    
                    var digits = string.Empty;
                    foreach(var c in part2)
                    {
                        if(c.IsDecimalDigit())
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
                     
                if(n != ulong.MaxValue && w != int.MaxValue && indicator != AsciSym.Question) 
                    return NatSpanSig.Define((int)n, w, indicator);
                else 
                    return default;             
            }
            else
                return default;
        }

        public static Option<Moniker> id(Type src)
        {
            if(src.IsNatSpan())
            {
                var typeargs = src.GetGenericArguments().ToArray();                    
                var text = "ns";
                text += NatType.value(typeargs[0]);
                text += Moniker.SegSep;
                text += PrimalType.signature(typeargs[1]);
                return Moniker.Parse(text);
            }
            else
                return default;
        }

    }
}