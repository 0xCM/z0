//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Generate
{
    public class QuintetGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new QuintetGenerator();

        public override byte Digits => 5;

        public override byte MaxValue => 31;
    }
}