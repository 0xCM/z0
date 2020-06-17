//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class BitSet
    {
        public static ReadOnlySpan<single> Singles
        {
            [MethodImpl(Inline)]
            get => Control.cast<byte,single>(BitSetData.Singletons);
        }

        public static ReadOnlySpan<duet> Duets
        {
            [MethodImpl(Inline)]
            get => Control.cast<byte,duet>(BitSetData.Duets);
        }

        public static ReadOnlySpan<triad> Triads
        {
            [MethodImpl(Inline)]
            get => Control.cast<byte,triad>(BitSetData.Triads);
        }

        public static ReadOnlySpan<quartet> Quartets
        {
            [MethodImpl(Inline)]
            get => Control.cast<byte,quartet>(BitSetData.Quartets);
        }

        public static ReadOnlySpan<quintet> Quintets
        {
            [MethodImpl(Inline)]
            get => Control.cast<byte,quintet>(BitSetData.Quintets);
        }
   }
}