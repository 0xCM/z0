//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct EffectiveAddress
    {
        public RegIndex Base;

        public RegIndex Index;

        public MemoryScale Scale;

        public uint Disp;

        public RegWidth RegWidth;

        public DataWidth DispWidth;
    }
}