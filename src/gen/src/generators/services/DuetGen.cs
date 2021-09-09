//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class DuetGen : BitSetGen
    {
        public static BitSetGen Service => new DuetGen();

        public override byte Digits => 2;

        public override byte MaxValue => 3;
    }
}