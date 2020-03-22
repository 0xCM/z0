//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using TC = System.TypeCode;
    using NC = NumericClass;
    using FW = FixedWidth;
    using NI = NumericIndicator;
    
    public static class NumericClasses
    {
        [Op]
        public static NumericClass classify(Type src)
            => Type.GetTypeCode(src)  switch {
                
                TC.SByte => NC.Int8i,
                 
                 TC.Byte => NC.Int8u,

                 TC.Int16  => NC.Int16i,

                 TC.UInt16 => NC.Int16u,
                
                 TC.Int32 => NC.Int32i,

                 TC.UInt32 => NC.Int32u,

                 TC.Int64 => NC.Int64i,

                 TC.UInt64 => NC.Int64u,

                 TC.Single => NC.Float32,

                TC.Double => NC.Float64,
                 _ => src.IsBit()  ? NC.Bit : NC.None
                 };        

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [Op]
        public static Type classified(NC k)
            => k switch {
                NC.Int8u => typeof(byte),
                NC.Int8i => typeof(sbyte),
                NC.Int16u => typeof(ushort),
                NC.Int16i => typeof(short),
                NC.Int32u => typeof(uint),
                NC.Int32i => typeof(int),
                NC.Int64i => typeof(long),
                NC.Int64u => typeof(ulong),
                NC.Float32 => typeof(float),
                NC.Float64 => typeof(double),
                NC.Bit => typeof(bit),
                _ => throw new NotSupportedException(k.ToString())
            };

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static int? width(NumericClass k)
        {
            var width =  (int)(k & NumericClass.Widths);
            return width == 8  || width == 16 | width == 32 | width == 64 ? width : (int?)null;
        }

        [MethodImpl(Inline), Op]
        public static NumericIndicator indicator(NumericClass k)
            => (k & NC.Signed) != 0 ? NumericIndicator.Signed :
               (k & NC.Float) != 0 ?  NumericIndicator.Float 
                                   :  NumericIndicator.Unsigned;

        /// <summary>
        /// Assigns class predicated on bit-widh and indicator
        /// </summary>
        /// <param name="width">The numeric bit width</param>
        /// <param name="indicator">The numeric indicator</param>
        [Op]
        public static NumericClass from(FixedWidth width, NumericIndicator indicator)
            => indicator switch {
                NI.Signed 
                    => width switch {                    
                        FW.W8  => NC.Int8i,
                        FW.W16 => NC.Int16i,
                        FW.W32 => NC.Int32i,
                        FW.W64 => NC.Int64i,
                        _ => NC.None
                    },
                NI.Unsigned 
                    => width switch {
                        FW.W8  => NC.Int8u,
                        FW.W16 => NC.Int16u,
                        FW.W32 => NC.Int32u,
                        FW.W64 => NC.Int64u,
                        _ => NC.None
                    },
                NI.Float 
                    => width switch {
                        FW.W32 => NC.Float32,
                        FW.W64 => NC.Float64,
                        _ => NC.None
                    },
                _ => NC.None
            };

        /// <summary>
        /// Determines the numeric class from a parametric type
        /// </summary>
        /// <typeparam name="T">The type to classify</typeparam>
        [MethodImpl(Inline)]
        public static NumericClass classify<T>()
            where T : struct
                => classify_u<T>();

        [MethodImpl(Inline)]
        static NC classify_u<T>()
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return NC.Int8u;
            else if(typeof(T) == typeof(ushort))
                return NC.Int16u;
            else if(typeof(T) == typeof(uint))
                return NC.Int32u;
            else if(typeof(T) == typeof(ulong))
                return NC.Int64u;
            else
                return classify_i<T>();
        }

        [MethodImpl(Inline)]
        static NC classify_i<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return NC.Int8i;
            else if(typeof(T) == typeof(short))
                return NC.Int16i;
            else if(typeof(T) == typeof(int))
                return NC.Int32i;
            else if(typeof(T) == typeof(long))
                return NC.Int64i;
            else
                return classify_f<T>();
        }

        [MethodImpl(Inline)]
        static NC classify_f<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return NC.Float32;
            else if(typeof(T) == typeof(double))
                return NC.Float64;
            else
                return NC.None;
        }
    }
}