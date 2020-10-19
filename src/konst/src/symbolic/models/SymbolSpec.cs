//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Table(TableId,FieldCount)]
    public struct SymbolSpec : ISymbolSpec
    {
        public const string TableId = "symbols.spec";

        public const byte FieldCount = 6;

        public ushort SymWidth;

        public ushort SegWidth;

        public ushort SegCapacity;

        public ClrArtifactKey SegDomain;

        public ClrArtifactKey SymDomain;

        public ClrArtifactKey KindDomain;

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ClrArtifactKey seg, ClrArtifactKey sym, ClrArtifactKey kind = default)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = seg;
            SymDomain = sym;
            KindDomain = kind;
        }

        ushort ISymbolSpec.SymWidth
            => SymWidth;

        ushort ISymbolSpec.SegWidth
            => SegWidth;

        ushort ISymbolSpec.SegCapacity
            => SegCapacity;

        ClrArtifactKey ISymbolSpec.SegDomain
            => SegDomain;

        ClrArtifactKey ISymbolSpec.SymDomain
            => SymDomain;
    }
}