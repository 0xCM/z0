//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Applies an logical leftwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref T sll<T>(ref T src, int offset)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                math.sll(ref int8(ref src), offset);
            else if(typematch<T,byte>())
                math.sll(ref uint8(ref src), offset);
            else if(typematch<T,short>())
                math.sll(ref int16(ref src), offset);
            else if(typematch<T,ushort>())
                math.sll(ref uint16(ref src), offset);
            else if(typematch<T,int>())
                math.sll(ref int32(ref src), offset);
            else if(typematch<T,uint>())
                math.sll(ref uint32(ref src), offset);
            else if(typematch<T,long>())
                math.sll(ref int64(ref src), offset);
            else if(typematch<T,ulong>())
                math.sll(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        /// <summary>
        /// Applies a logical leftwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static T sll<T>(T src, int offset)
            where T : unmanaged
                => sll(ref src, offset);
    }
}