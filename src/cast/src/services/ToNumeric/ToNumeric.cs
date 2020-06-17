//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static FromNumeric;
    using static As;    

    using TC = System.TypeCode;
    
    [ApiHost("to.numeric")]
    public partial class ToNumeric
    {
        [MethodImpl(Inline)]
        public static T to<S,T>(S src)
            => to_u<S,T>(src);
        
        [MethodImpl(Inline)]
        static T to_u<S,T>(S src)
        {
            if(typeof(S) == typeof(byte))
                return to<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return to<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return to<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return to<T>(uint64(src));
            else
                return to_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<S,T>(S src)
        {
            if(typeof(S) == typeof(sbyte))
                return to<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return to<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return to<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return to<T>(int64(src));
            else 
                return to_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<S,T>(S src)
        {
            if(typeof(S) == typeof(float))
                return to<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return to<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return to<T>(char16(src));
            else            
                return Unsupported.define<S,T>(src);
        }

        /// <summary>
        /// Uncoditionaly converts a boxed numeric value of one kind to a boxed numeric value of specified kind, if possible.
        /// If not possible, returns the original value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target kind</param>
        [Op]
        public static object to(object src, NumericKind dst)
        {
            var tc = Type.GetTypeCode(src?.GetType());
            switch(tc)
            {
                case TC.SByte:
                    return from((sbyte)src, dst);

                case TC.Byte:
                    return from((byte)src, dst);

                case TC.Int16:
                    return from((short)src, dst);

                case TC.UInt16:
                    return from((ushort)src, dst);
                
                case TC.Int32:
                    return from((int)src, dst);

                case TC.UInt32:
                    return from((uint)src, dst);

                case TC.Int64:
                    return from((long)src, dst);

                case TC.UInt64:
                    return from((ulong)src, dst);

                case TC.Single:
                    return from((float)src, dst);

                case TC.Double:
                    return from((double)src, dst);
            }
            return src;
        }
    }
}