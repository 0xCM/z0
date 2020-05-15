//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        
    using static LegacyPrefixes;

    public readonly struct LegacyPrefixGroups
    {
        public static LegacyPrefixGroups Empty => new LegacyPrefixGroups(0);

        readonly HexIndex<LegacyPrefixGroup> Index;        

        [MethodImpl(Inline)]
        public static LegacyPrefixGroups Create() 
            => new LegacyPrefixGroups(1);
        
        [MethodImpl(Inline)]
        LegacyPrefixGroups(byte i)
        {
            if(i != 0)
                Index = HexIndex.Define<LegacyPrefixGroup>(OzO, AzO, CS, DS, ES, FS, GS, SS, LOCK, REPE, REPZ);
            else
                Index = HexIndex.Empty<LegacyPrefixGroup>();
        }
        
        public LegacyPrefixGroup this[LegacyPrefixKind kind]
        {
            [MethodImpl(Inline)]
            get => Index[(HexKind)kind];
        }
    }
}