//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref As.uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack(src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }

        /// <summary>
        /// Unpacks 8 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref As.uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref As.uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
            unpack((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);     
            unpack((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);     
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref As.uint8(ref buffer);
            ref var lead = ref head(dst);
            
            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
            unpack((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);     
            unpack((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);     
            unpack((byte)(src >> 32), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 32);     
            unpack((byte)(src >> 40), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 40);     
            unpack((byte)(src >> 48), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 48);                 
            unpack((byte)(src >> 56), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 56);     
        }   
    }
}