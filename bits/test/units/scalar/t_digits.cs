//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
        
    public class t_digits : ScalarBitTest<t_digits>
    {
        public void binary_digits_8u()
        {
            bd_match_check<byte>("0b00000100",0b00000100);
            bd_match_check<byte>("0b00000101",0b00000101);
            bd_match_check<byte>("0b01000101",0b01000101);
            binary_digits_check<byte>();

        }

        public void binary_digits_16u()
            => binary_digits_check<ushort>();

        public void binary_digits_32u()
            => binary_digits_check<uint>();

        public void binary_digits_64u()
            => binary_digits_check<ulong>();


        public void decimal_digit_match_8u()
        {
            dd_match_check<byte>("0", 0);
            dd_match_check<byte>("25", 25);
            dd_match_check<byte>("101", 101);
            dd_match_check<byte>("255", 255);
        }

        void binary_digits_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                bd_match_check<T>(BitString.from(x).Format(false,true),x);
            }

        }

        static void bd_match_check<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToBinaryDigits().Format(true));

        static void dd_match_check<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToDecimalDigits().Format());
    }
}