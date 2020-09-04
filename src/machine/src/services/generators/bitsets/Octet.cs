//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class OctetGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new OctetGenerator();

        public override byte Digits => 8;

        public override byte MaxValue => 255;
    }
}