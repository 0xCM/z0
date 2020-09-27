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
        protected override int CycleCount => (int)Pow2.T24;

        public void check_add()
        {
            Claim.nea(Bit32.Off + Bit32.Off);
            Claim.Require(Bit32.On + Bit32.Off);
            Claim.Require(Bit32.Off + Bit32.On);
            Claim.nea(Bit32.On + Bit32.On);
        }

        public void check_and()
        {
            Claim.nea(Bit32.Off && Bit32.Off);
            Claim.nea(Bit32.On && Bit32.Off);
            Claim.nea(Bit32.Off && Bit32.On);
            Claim.Require(Bit32.On && Bit32.On);
        }

        public void check_or()
        {
            Claim.nea(Bit32.Off || Bit32.Off);
            Claim.Require(Bit32.On || Bit32.Off);
            Claim.Require(Bit32.Off || Bit32.On);
            Claim.Require(Bit32.On || Bit32.On);
        }

        public void check_xor()
        {
            Claim.nea(Bit32.Off ^ Bit32.Off);
            Claim.Require(Bit32.On ^ Bit32.Off);
            Claim.Require(Bit32.Off ^ Bit32.On);
            Claim.nea(Bit32.On ^ Bit32.On);
        }

        public void check_not()
        {
            Claim.Require(~Bit32.Off);
            Claim.Require(!Bit32.Off);
            Claim.nea(~Bit32.On);
            Claim.nea(!Bit32.On);
        }

        public void check_nand()
        {
            Claim.Require(Bit32.nand(Bit32.Off,  Bit32.Off));
            Claim.Require(Bit32.nand(Bit32.On,  Bit32.Off));
            Claim.Require(Bit32.nand(Bit32.Off,  Bit32.On));
            Claim.nea(Bit32.nand(Bit32.On,  Bit32.On));
        }

        public void check_nor()
        {
            Claim.Require(Bit32.nor(Bit32.Off,  Bit32.Off));
            Claim.nea(Bit32.nor(Bit32.On,  Bit32.Off));
            Claim.nea(Bit32.nor(Bit32.Off,  Bit32.On));
            Claim.nea(Bit32.nor(Bit32.On,  Bit32.On));
        }

        public void check_xnor()
        {
            Claim.Require(Bit32.xnor(Bit32.Off,  Bit32.Off));
            Claim.nea(Bit32.xnor(Bit32.On,  Bit32.Off));
            Claim.nea(Bit32.xnor(Bit32.Off,  Bit32.On));
            Claim.Require(Bit32.xnor(Bit32.On,  Bit32.On));
        }

        public void check_equality()
        {
            Claim.Require(Bit32.Off ==  Bit32.Off);
            Claim.Require(Bit32.On !=  Bit32.Off);
            Claim.Require(Bit32.Off != Bit32.On);
            Claim.Require(Bit32.On ==  Bit32.On);
        }
    }
}