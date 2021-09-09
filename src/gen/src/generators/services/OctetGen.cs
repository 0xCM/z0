//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Generate
{
    public class OctetGen : BitSetGen
    {
        public static BitSetGen Service => new OctetGen();

        public override byte Digits => 8;

        public override byte MaxValue => 255;
    }
}