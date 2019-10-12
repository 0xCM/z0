//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static VecParts128x8u;

    public static class Vec128PatternData
    {
        /// <summary>
        /// Defines components {0,1,..., 14,15} for a 128x8u vector 
        /// </summary>
        public static ReadOnlySpan<byte> Inc_8u  => new byte[16]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_8x8u  => new byte[16]{P,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_16x8u  => new byte[16]{O,P,A,B,C,D,E,F,G,H,I,J,K,L,M,N};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_24x8u  => new byte[16]{N,O,P,A,B,C,D,E,F,G,H,I,J,K,L,M};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_32x8u  => new byte[16]{M,N,O,P,A,B,C,D,E,F,G,H,I,J,K,L};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_8x8u  => new byte[16]{B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,A};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_16x8u  => new byte[16]{C,D,E,F,G,H,I,J,K,L,M,N,O,P,A,B};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_24x8u  => new byte[16]{D,E,F,G,H,I,J,K,L,M,N,O,P,A,B,C};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_32x8u  => new byte[16]{E,F,G,H,I,J,K,L,M,N,O,P,A,B,C,D};


    }

}