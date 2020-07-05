//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    using D = BitSeqData;

    public partial class BitSeqD
    {
        public static ReadOnlySpan<uint1> U1
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint1>(D.Singletons);
        }

        public static ReadOnlySpan<uint2> U2
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint2>(D.Duets);
        }

        public static ReadOnlySpan<uint3> U3
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint3>(D.Triads);
        }

        public static ReadOnlySpan<uint4> U4
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint4>(D.Quartets);
        }

        public static ReadOnlySpan<uint5> U5
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint5>(D.Quintets);
        }

        public static ReadOnlySpan<uint6> U6
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint6>(D.Sextets);
        }        

        public static ReadOnlySpan<uint6> U7
        {
            [MethodImpl(Inline)]
            get => recover<byte,uint6>(D.Septets);
        }        

        public static ReadOnlySpan<octet> U8
        {
            [MethodImpl(Inline)]
            get => recover<byte,octet>(D.Octets);
        }        
   }
}