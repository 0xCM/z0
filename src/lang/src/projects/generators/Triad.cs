//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Generate
{
    public class TriadGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new TriadGenerator();

        public override byte Digits => 3;

        public override byte MaxValue => 7;
    }
}