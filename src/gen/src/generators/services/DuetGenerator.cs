//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class DuetGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new DuetGenerator();

        public override byte Digits => 2;

        public override byte MaxValue => 3;
    }
}