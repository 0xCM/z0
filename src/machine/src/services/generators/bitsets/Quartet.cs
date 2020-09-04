//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class QuartetGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new QuartetGenerator();

        public override byte Digits => 4;

        public override byte MaxValue => 15;
    }
}