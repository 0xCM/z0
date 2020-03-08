//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Root;
    using static As;

    partial class gbits
    {        
        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit testbit<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return bit.test(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                 return bit.test(uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                 return bit.test(uint32(src), pos);
            else if(typeof(T) == typeof(ulong))
                 return bit.test(uint64(src), pos);
            else
                return testbit2_i(src,pos);
        }

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline)]
        public static bit testbit<T>(T src, byte pos)
            where T : unmanaged
                => testbit(src,(int)pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline)]
        public static bit testbit(ushort src, int pos)        
            => bit.test(src,pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline)]
        static bit testbit(float src, int pos)        
           => bit.test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline)]
        static bit testbit(double src, int pos)        
            => bit.test(BitConverter.DoubleToInt64Bits(src),pos);

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to chech</param>
        [MethodImpl(Inline)]
        static bit testbit2_i<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return bit.test(int8(src), pos);
            else if(typeof(T) == typeof(short))
                 return bit.test(int16(src), pos);
            else if(typeof(T) == typeof(int))
                 return bit.test(int32(src), pos);
            else if(typeof(T) == typeof(long))
                 return bit.test(int64(src), pos);
            else
                return testbit_f(src,pos);
        }

        [MethodImpl(Inline)]
        static bit testbit_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return testbit(float32(src), pos);
            else if(typeof(T) == typeof(double))
                 return testbit(float64(src), pos);
            else
                throw unsupported<T>();
        }           
    }
}