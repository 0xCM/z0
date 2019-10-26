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
        const int n = 16;

        public static ReadOnlySpan<byte> Inc8u  
            => new byte[n]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        public static ReadOnlySpan<byte> Inc16u  
            => new byte[n]{A,0,B,0,C,0,D,0,E,0,F,0,G,0,H,0};

        public static ReadOnlySpan<byte> Inc32u  
            => new byte[n]{A,0,0,0,B,0,0,0,C,0,0,0,D,0,0,0};

        public static ReadOnlySpan<byte> Inc64u  
            => new byte[n]{A,0,0,0,0,0,0,0,B,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Dec8u 
            => new byte[n]{P,O,N,M,L,K,J,I,H,G,F,E,D,C,B,A};

        public static ReadOnlySpan<byte> Dec16u  
            => new byte[n]{H,0,G,0,F,0,E,0,D,0,C,0,B,0,A,0};

        public static ReadOnlySpan<byte> Dec32u  
            => new byte[n]{D,0,0,0,C,0,0,0,B,0,0,0,A,0,0,0};

        public static ReadOnlySpan<byte> Dec64u  
            => new byte[n]{B,0,0,0,0,0,0,0,A,0,0,0,0,0,0,0};

        /// <summary>
        /// Defines a 128x8u vector where all components are of unit value 1
        /// </summary>
        public static ReadOnlySpan<byte> Units8u  
            => new byte[n]{B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B};        

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotL_8x8u  
            => new byte[n]{P,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotL_16x8u  
            => new byte[n]{O,P,A,B,C,D,E,F,G,H,I,J,K,L,M,N};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_24x8u  
            => new byte[n]{N,O,P,A,B,C,D,E,F,G,H,I,J,K,L,M};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotL_32x8u  
            => new byte[n]{M,N,O,P,A,B,C,D,E,F,G,H,I,J,K,L};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotR_8x8u  
            => new byte[n]{B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,A};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotR_16x8u  
            => new byte[n]{C,D,E,F,G,H,I,J,K,L,M,N,O,P,A,B};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotR_24x8u  
            => new byte[n]{D,E,F,G,H,I,J,K,L,M,N,O,P,A,B,C};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> RotR_32x8u 
            => new byte[n]{E,F,G,H,I,J,K,L,M,N,O,P,A,B,C,D};

    }

}