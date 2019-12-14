//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class BitMask
    {        
        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static byte setif(byte src, int srcpos, byte dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, srcpos);
            return dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ushort setif(ushort src, int srcpos, ushort dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            return dst;            
        }

        /// <summary>
        /// Enables a specified bit in the target if a specified bit is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static uint setif(uint src, int srcpos, uint dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            return dst;
        }

        /// <summary>
        /// Enables a specified bit in the target if a specified bit is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ulong setif(ulong src, int srcpos, ulong dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);                
            return dst;
        }
    }
}