//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
 
    public sealed class t_bit : UnitTest<t_bit>
    {
        protected override int CycleCount => Pow2.T24;

        public static void check_add()
        {
            Claim.nea(bit.Off + bit.Off);                
            Claim.yea(bit.On + bit.Off);                
            Claim.yea(bit.Off + bit.On);                
            Claim.nea(bit.On + bit.On);                
        }

        public static void check_and()
        {
            Claim.nea(bit.Off && bit.Off);                
            Claim.nea(bit.On && bit.Off);                
            Claim.nea(bit.Off && bit.On);                
            Claim.yea(bit.On && bit.On);                
        }

        public static void check_or()
        {
            Claim.nea(bit.Off || bit.Off);                
            Claim.yea(bit.On || bit.Off);                
            Claim.yea(bit.Off || bit.On);                
            Claim.yea(bit.On || bit.On);                
        }

        public static void check_xor()
        {
            Claim.nea(bit.Off ^ bit.Off);                
            Claim.yea(bit.On ^ bit.Off);                
            Claim.yea(bit.Off ^ bit.On);                
            Claim.nea(bit.On ^ bit.On);                
        }

        public static void check_not()
        {
            Claim.yea(~bit.Off);                
            Claim.yea(!bit.Off);                
            Claim.nea(~bit.On);                
            Claim.nea(!bit.On);                
        }

        public static void check_nand()
        {
            Claim.yea(bit.nand(bit.Off,  bit.Off));                
            Claim.yea(bit.nand(bit.On,  bit.Off));                
            Claim.yea(bit.nand(bit.Off,  bit.On));                
            Claim.nea(bit.nand(bit.On,  bit.On));                
        }

        public static void check_nor()
        {
            Claim.yea(bit.nor(bit.Off,  bit.Off));                
            Claim.nea(bit.nor(bit.On,  bit.Off));                
            Claim.nea(bit.nor(bit.Off,  bit.On));                
            Claim.nea(bit.nor(bit.On,  bit.On));                
        }

        public static void check_xnor()
        {
            Claim.yea(bit.xnor(bit.Off,  bit.Off));                
            Claim.nea(bit.xnor(bit.On,  bit.Off));                
            Claim.nea(bit.xnor(bit.Off,  bit.On));                
            Claim.yea(bit.xnor(bit.On,  bit.On));                
        }

        public static void check_equality()
        {
            Claim.yea(bit.Off ==  bit.Off);                
            Claim.yea(bit.On !=  bit.Off);                
            Claim.yea(bit.Off != bit.On);                
            Claim.yea(bit.On ==  bit.On);                
        }

    }

}