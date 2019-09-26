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
        /// Applies a logical rightwards shift to the source operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static T srl<T>(T src, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.srl(ref int8(ref src), offset));
            else if(typematch<T,byte>())
                return generic<T>(math.srl(ref uint8(ref src), offset));
            else if(typematch<T,short>())
                return generic<T>(math.srl(ref int16(ref src), offset));
            else if(typematch<T,ushort>())
                return generic<T>(math.srl(ref uint16(ref src), offset));
            else if(typematch<T,int>())
                return generic<T>(math.srl(ref int32(ref src), offset));
            else if(typematch<T,uint>())
                return generic<T>(math.srl(ref uint32(ref src), offset));
            else if(typematch<T,long>())
                return generic<T>(math.srl(ref int64(ref src), offset));
            else if(typematch<T,ulong>())
                return generic<T>(math.srl(ref uint64(ref src), offset));
            else
                throw unsupported<T>();
            
        }
        /// <summary>
        /// Applies a logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref T srl<T>(ref T src, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.srl(ref int8(ref src), offset);
            else if(typematch<T,byte>())
                math.srl(ref uint8(ref src), offset);
            else if(typematch<T,short>())
                math.srl(ref int16(ref src), offset);
            else if(typematch<T,ushort>())
                math.srl(ref uint16(ref src), offset);
            else if(typematch<T,int>())
                math.srl(ref int32(ref src), offset);
            else if(typematch<T,uint>())
                math.srl(ref uint32(ref src), offset);
            else if(typematch<T,long>())
                math.srl(ref int64(ref src), offset);
            else if(typematch<T,ulong>())
                math.srl(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }


    }
}