//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed class t_enums : UnitTest<t_enums>
    {

        public enum Choices8u : byte
        {
            C0, C1, C2, C3, C4, C5
        }

        public enum Choices32i : int
        {
            C0 = 1,  C1 = 2, C2 = C1*2, C3 = C2*2, 
            C4 = C3*2, C5 = C4*2, C6 = C5*2, C7 = C6*2,
            C99 = byte.MaxValue,
        
        }

        public void check_enum_values()
        {
            var values = Enums.values<Choices32i,int>();
            Claim.eq(Enum.GetValues(typeof(Choices32i)).Length, values.Length);

            for(var i = 0; i<values.Length; i++)
            {
                var ival = values[i].NumericValue;
                if(ival == byte.MaxValue)
                    break;

                var member = Enums.literal<Choices32i,int>(ival);
                Claim.eq(member, values[i].LiteralValue);

                var expect = (int)Math.Pow(2,i);
                if(expect != ival)
                    Notify($"{values[i]} = {ival} != {expect}");
                Claim.eq(expect, ival);                            
            }
        }

        // public void check_literal_correlation()
        // {
        //     var first = Enums.literals<BinaryBitLogicKindId>();
        //     var second = Enums.literals<BinaryBitLogicOpKind>();            
        //     if(first.Length != second.Length)
        //     {
        //         var firstNames = first.NamedValues.Names();
        //         var secondNames = second.NamedValues.Names();
        //         var q1 = from n in firstNames where !secondNames.Contains(n) select n;
        //         var q2 = from n in secondNames where !firstNames.Contains(n) select n;

        //         iter(q2, n => Notify($"Missing from first: {n}"));
        //         iter(q1, n => Notify($"Missing from second: {n}"));
        //     }

        //     var correlated = Enums.correlate<BinaryBitLogicKindId, BinaryBitLogicOpKind>();
        //     Claim.eq(correlated.Count, first.Length);

        // }

        public void check_numeric_class()
        {
            
            Claim.eq(NumericClass.Int16u.Width(), 16);
            Claim.eq(NumericClass.Int32i.Width(), 32);
            Claim.eq(NumericClass.All.Width(), null);

        }
    }
}