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
    using static VecParts256x8u;

    public static class VecPatternData
    {

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> increments<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return Inc128x8u;
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return Inc128x16u;
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return Inc128x32u;
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return Inc128x64u;
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> increments<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return Inc256x8u;
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return Inc256x16u;
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return Inc256x32u;
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return Inc256x64u;
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> decrements<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return Dec128x8u;
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return Dec128x16u;
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return Dec128x32u;
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return Dec128x64u;
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> decrements<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return Dec256x8u;
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return Dec256x16u;
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return Dec256x32u;
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return Dec256x64u;
            else
                throw unsupported<T>();
        }


        /// <summary>
        /// Defines the sequence [0,1,...,14,15]
        /// </summary>
        public static ReadOnlySpan<byte> Inc128x8u  
            => new byte[16]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        public static ReadOnlySpan<byte> Inc128x16u  
            => new byte[16]{A,0,B,0,C,0,D,0,E,0,F,0,G,0,H,0};

        public static ReadOnlySpan<byte> Inc128x32u  
            => new byte[16]{A,0,0,0,B,0,0,0,C,0,0,0,D,0,0,0};

        public static ReadOnlySpan<byte> Inc128x64u  
            => new byte[16]{A,0,0,0,0,0,0,0,B,0,0,0,0,0,0,0};

        /// <summary>
        /// Defines the sequence [0,1,...,30,31]
        /// </summary>
        public static ReadOnlySpan<byte> Inc256x8u  
            => new byte[32]{
                LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,
                HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,
            };

        public static ReadOnlySpan<byte> Inc256x16u  
            => new byte[32]{
                LA,0,LB,0,LC,0,LD,0,LE,0,LF,0,LG,0,LH,0,
                HA,0,HB,0,HC,0,HD,0,HE,0,HF,0,HG,0,HH,0,
            };

        public static ReadOnlySpan<byte> Inc256x32u  
            => new byte[32]{
                LA,0,0,0,LB,0,0,0,LC,0,0,0,LD,0,0,0,
                HE,0,0,0,HF,0,0,0,HG,0,0,0,HH,0,0,0,
            };

        public static ReadOnlySpan<byte> Inc256x64u  
            => new byte[32]{
                LA,0,0,0,0,0,0,0,LB,0,0,0,0,0,0,0,
                HC,0,0,0,0,0,0,0,HD,0,0,0,0,0,0,0,
            };

        /// <summary>
        /// Defines the sequence [15,14,...,1,0]
        /// </summary>
        public static ReadOnlySpan<byte> Dec128x8u 
            => new byte[16]{P,O,N,M,L,K,J,I,H,G,F,E,D,C,B,A};

        public static ReadOnlySpan<byte> Dec128x16u  
            => new byte[16]{H,0,G,0,F,0,E,0,D,0,C,0,B,0,A,0};

        public static ReadOnlySpan<byte> Dec128x32u  
            => new byte[16]{D,0,0,0,C,0,0,0,B,0,0,0,A,0,0,0};

        public static ReadOnlySpan<byte> Dec128x64u  
            => new byte[16]{B,0,0,0,0,0,0,0,A,0,0,0,0,0,0,0};

        /// <summary>
        /// Defines the sequence [31,30,...,1,0]
        /// </summary>
        public static ReadOnlySpan<byte> Dec256x8u  
            => new byte[32]{
                HP,HO,HN,HM,HL,HK,HJ,HI,HH,HG,HF,HE,HD,HC,HB,HA,
                LP,LO,LN,LM,LL,LK,LJ,LI,LH,LG,LF,LE,LD,LC,LB,LA
            };

        public static ReadOnlySpan<byte> Dec256x16u  
            => new byte[32]{
                HH,0,HG,0,HF,0,HE,0,HD,0,HC,0,HB,0,HA,0,
                LH,0,LG,0,LF,0,LE,0,LD,0,LC,0,LB,0,LA,0,
            };

        public static ReadOnlySpan<byte> Dec256x32u  
            => new byte[32]{
                HH,0,0,0,HG,0,0,0,HF,0,0,0,HE,0,0,0,
                LD,0,0,0,LC,0,0,0,LB,0,0,0,LA,0,0,0,
            };

        public static ReadOnlySpan<byte> Dec256x64u  
            => new byte[32]{
                HD,0,0,0,0,0,0,0,HC,0,0,0,0,0,0,0,
                LB,0,0,0,0,0,0,0,LA,0,0,0,0,0,0,0,
            };
 
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N8 offset)
            => RotL8_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N16 offset)
            => RotL16_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N24 offset)
            => RotL24_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N32 offset)
            => RotL32_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N40 offset)
            => RotL40_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotl(N128 n, N48 offset)
            => RotL48_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N8 offset)
            => RotR8_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N16 offset)
            => RotR16_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N24 offset)
            => RotR24_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N32 offset)
            => RotR32_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N40 offset)
            => RotR40_128x8u;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> rotr(N128 n, N48 offset)
            => RotR48_128x8u;

 
        /// <summary>
        /// Defines a 128x8u vector where all components are of unit value 1
        /// </summary>
        public static ReadOnlySpan<byte> Units128x8u  
            => new byte[16]{B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B};        

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 8 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL8_128x8u  
            => new byte[16]{P,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 16 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL16_128x8u  
            => new byte[16]{O,P,A,B,C,D,E,F,G,H,I,J,K,L,M,N};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 24 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL24_128x8u  
            => new byte[16]{N,O,P,A,B,C,D,E,F,G,H,I,J,K,L,M};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 32 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL32_128x8u  
            => new byte[16]{M,N,O,P,A,B,C,D,E,F,G,H,I,J,K,L};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL40_128x8u  
            => new byte[16]{L,M,N,O,P,A,B,C,D,E,F,G,H,I,J,K};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL48_128x8u  
            => new byte[16]{K,L,M,N,O,P,A,B,C,D,E,F,G,H,I,J};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 8 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR8_128x8u  
            => new byte[16]{B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,A};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 16 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR16_128x8u  
            => new byte[16]{C,D,E,F,G,H,I,J,K,L,M,N,O,P,A,B};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 24 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR24_128x8u  
            => new byte[16]{D,E,F,G,H,I,J,K,L,M,N,O,P,A,B,C};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 32 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR32_128x8u 
            => new byte[16]{E,F,G,H,I,J,K,L,M,N,O,P,A,B,C,D};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR40_128x8u 
            => new byte[16]{F,G,H,I,J,K,L,M,N,O,P,A,B,C,D,E};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 48 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR48_128x8u 
            => new byte[16]{G,H,I,J,K,L,M,N,O,P,A,B,C,D,E,F};

    }

}