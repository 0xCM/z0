//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public class TriadGenerator : BitSetGenerator
    {
        public static BitSetGenerator Service => new TriadGenerator();

        public override int Digits => 3;

        public override byte MaxValue => 7;
    }
}