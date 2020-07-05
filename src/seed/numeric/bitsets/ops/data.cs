//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using D = BitSetData;

    public partial class BitSet
    {
        public static ReadOnlySpan<single> Singles
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,single>(D.Singletons);
        }

        public static ReadOnlySpan<duet> Duets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,duet>(D.Duets);
        }

        public static ReadOnlySpan<triad> Triads
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,triad>(D.Triads);
        }

        public static ReadOnlySpan<quartet> Quartets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,quartet>(D.Quartets);
        }

        public static ReadOnlySpan<quintet> Quintets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,quintet>(D.Quintets);
        }

        public static ReadOnlySpan<sextet> Sextets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,sextet>(D.Sextets);
        }        

        public static ReadOnlySpan<octet> Octets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,octet>(D.Octets);
        }        
   }
}