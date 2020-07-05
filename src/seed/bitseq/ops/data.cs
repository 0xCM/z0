//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using D = BitSeqData;

    public partial class BitSeqD
    {
        public static ReadOnlySpan<uint1> Singles
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint1>(D.Singletons);
        }

        public static ReadOnlySpan<uint2> Duets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint2>(D.Duets);
        }

        public static ReadOnlySpan<uint3> Triads
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint3>(D.Triads);
        }

        public static ReadOnlySpan<uint4> Quartets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint4>(D.Quartets);
        }

        public static ReadOnlySpan<uint5> Quintets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint5>(D.Quintets);
        }

        public static ReadOnlySpan<uint6> Sextets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint6>(D.Sextets);
        }        

        public static ReadOnlySpan<uint6> Septets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,uint6>(D.Septets);
        }        

        public static ReadOnlySpan<octet> Octets
        {
            [MethodImpl(Inline)]
            get => Root.cast<byte,octet>(D.Octets);
        }        
   }
}