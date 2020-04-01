//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
 
    public sealed class t_bit : UnitTest<t_bit>
    {
        protected override int CycleCount => Pow2.T24;

        public void check_add()
        {
            Claim.nea(bit.Off + bit.Off);                
            Claim.require(bit.On + bit.Off);                
            Claim.require(bit.Off + bit.On);                
            Claim.nea(bit.On + bit.On);                
        }

        public void check_and()
        {
            Claim.nea(bit.Off && bit.Off);                
            Claim.nea(bit.On && bit.Off);                
            Claim.nea(bit.Off && bit.On);                
            Claim.require(bit.On && bit.On);                
        }

        public void check_or()
        {
            Claim.nea(bit.Off || bit.Off);                
            Claim.require(bit.On || bit.Off);                
            Claim.require(bit.Off || bit.On);                
            Claim.require(bit.On || bit.On);                
        }

        public void check_xor()
        {
            Claim.nea(bit.Off ^ bit.Off);                
            Claim.require(bit.On ^ bit.Off);                
            Claim.require(bit.Off ^ bit.On);                
            Claim.nea(bit.On ^ bit.On);                
        }

        public void check_not()
        {
            Claim.require(~bit.Off);                
            Claim.require(!bit.Off);                
            Claim.nea(~bit.On);                
            Claim.nea(!bit.On);                
        }

        public void check_nand()
        {
            Claim.require(bit.nand(bit.Off,  bit.Off));                
            Claim.require(bit.nand(bit.On,  bit.Off));                
            Claim.require(bit.nand(bit.Off,  bit.On));                
            Claim.nea(bit.nand(bit.On,  bit.On));                
        }

        public void check_nor()
        {
            Claim.require(bit.nor(bit.Off,  bit.Off));                
            Claim.nea(bit.nor(bit.On,  bit.Off));                
            Claim.nea(bit.nor(bit.Off,  bit.On));                
            Claim.nea(bit.nor(bit.On,  bit.On));                
        }

        public void check_xnor()
        {
            Claim.require(bit.xnor(bit.Off,  bit.Off));                
            Claim.nea(bit.xnor(bit.On,  bit.Off));                
            Claim.nea(bit.xnor(bit.Off,  bit.On));                
            Claim.require(bit.xnor(bit.On,  bit.On));                
        }

        public void check_equality()
        {
            Claim.require(bit.Off ==  bit.Off);                
            Claim.require(bit.On !=  bit.Off);                
            Claim.require(bit.Off != bit.On);                
            Claim.require(bit.On ==  bit.On);                
        }
        
        public void format_simple()
        {
            var x = 0b110011101111100u;
            var f =  BitFormatter.Define<uint>();
            var s1 = f.Format(x);
            
            //Trace(s1);

            var config2 = BitFormatConfig.Tlz;
            var s2 = f.Format(x,config2);
            //Trace(s2);

            var config3 = BitFormatConfig.Blocked(4);
            var s3 = f.Format(x,config3);
            //Trace(s3);

            var config4 = BitFormatConfig.Limited(10);
            var s4 = f.Format(x,config4);
            //Trace(s4);

            var config5 = config4.WithSpecifier();
            var s5 = f.Format(x,config5);
            //Trace(s5);

        }

    }

}