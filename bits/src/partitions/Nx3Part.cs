//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        const uint M3 = 0b111;

        /// <summary>
        /// Partitions the first 6 bits of a 32-bit source value into 2 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part6x3(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)(src >> 0 & M3);
            seek(ref dst, 1) = (byte)(src >> 3 & M3);
        }

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part6x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 9 bits of a 32-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part9x3(uint src, ref byte dst)
        {
            part6x3(src, ref dst);
            seek(ref dst, 2) = (byte)(src >> 6 & M3);
        }

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x3 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part9x3 part)
            => Bits.gather(src, (uint)part);


        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part12x3(uint src, ref byte dst)
        {
            part9x3(src, ref dst);
            seek(ref dst, 3) = (byte)(src >> 9 & M3);
        }

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part12x3(uint src, Span<byte> dst)
            => part12x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 15 bits of a 16-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part15x3(uint src, ref byte dst)
        {
            part12x3(src, ref dst);
            seek(ref dst, 4) = (byte)(src >> 12 & M3);
       }

        /// <summary>
        /// Partitions the first 15 bits of a 32-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part15x3(uint src, Span<byte> dst)
            => part15x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part15x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 18 bits of a 32-bit source into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part18x3(uint src, ref byte dst)
        {
            part15x3(src, ref dst);
            seek(ref dst, 5) = (byte)(src >> 15 & M3);
        }

        /// <summary>
        /// Partitions the first 18 bits of a 32-bit source into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part18x3(uint src, Span<byte> dst)
            => part18x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part18x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part18x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 21 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part21x3(uint src, ref byte dst)
        {
            part18x3(src, ref dst);
            seek(ref dst, 6) = (byte)(src >> 18 & M3);
        }

        /// <summary>
        /// Partitions the first 21 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part21x3(uint src, Span<byte> dst)
            => part21x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part21x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part21x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 8 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part24x3(uint src, ref byte dst)
        {
            part21x3(src, ref dst);
            seek(ref dst, 7) = (byte)(src >> 21 & M3);
        }

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 8 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part24x3(uint src, Span<byte> dst)
            => part24x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x3 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x3 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 8 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part27x3(uint src, ref byte dst)
        {
            part24x3(src, ref dst);
            seek(ref dst, 8) = (byte)(src >> 24 & M3);
        }

        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 9 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part27x3(uint src, Span<byte> dst)
            => part27x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part27x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part27x3 part)
            => Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static void part30x3(uint src, ref byte dst)
        {
            part27x3(src, ref dst);
            seek(ref dst, 9) = (byte)(src >> 27 & M3);
        }

        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source value into 10 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part30x3(uint src, Span<byte> dst)
            => part30x3(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part30x3 part)
            => Bits.gather(src, (uint)part);
    }
}