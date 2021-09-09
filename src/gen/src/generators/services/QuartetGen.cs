//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Generate
{
    public class QuartetGen : BitSetGen
    {
        public static BitSetGen Service => new QuartetGen();

        public override byte Digits => 4;

        public override byte MaxValue => 15;
    }
}