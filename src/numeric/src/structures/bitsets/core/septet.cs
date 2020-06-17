// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;

//     using analog = septet;

//     partial class BitSet
//     {
//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(byte src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(sbyte src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(ushort src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(short src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]    
//         public static analog uint7(int src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(uint src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]    
//         public static analog uint7(long src)
//             => new analog(src);

//         /// <summary>
//         /// Creates a 5-bit usigned integer from the least 5 bits of the source
//         /// </summary>
//         /// <param name="src">The source value</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(ulong src)        
//             => new analog((byte)((byte)src & analog.MaxVal));

//         /// <summary>
//         /// Constructs a uint7 value from a sequence of bits ranging from low to high
//         /// </summary>
//         /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
//         /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
//         /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
//         /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
//         [MethodImpl(Inline), Op]
//         public static analog uint7(bit x0, bit x1 = default, bit x2 = default, bit x3 = default, bit x4 = default)
//              => wrap7(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4));

//         [MethodImpl(Inline), Op]
//         public static analog add(analog x, analog y)
//         {
//             var sum = (byte)(x.data + y.data);
//             return wrap7((sum >= analog.Base) ? (byte)(sum - analog.Base): sum);
//         }

//         [MethodImpl(Inline), Op]
//         public static analog sub(analog x, analog y)
//         {
//             var diff = (int)x - (int)y;
//             return wrap7(diff < 0 ? (uint)(diff + analog.Base) : (uint)diff);
//         }

//         [MethodImpl(Inline), Op]
//         public static analog div (analog lhs, analog rhs) 
//             => wrap7((byte)(lhs.data / rhs.data));

//         [MethodImpl(Inline), Op]
//         public static analog mod (analog lhs, analog rhs)
//             => wrap7((byte)(lhs.data % rhs.data));

//         [MethodImpl(Inline), Op]
//         public static analog mul(analog lhs, analog rhs)
//             => reduce7(lhs.data * rhs.data);

//         [MethodImpl(Inline), Op]
//         public static analog or(analog lhs, analog rhs)
//             => wrap7((byte)(lhs.data | rhs.data));

//         [MethodImpl(Inline), Op]
//         public static analog and(analog lhs, analog rhs)
//             => wrap7((byte)(lhs.data & rhs.data));

//         [MethodImpl(Inline), Op]
//         public static analog xor(analog lhs, analog rhs)
//             => wrap7((byte)(lhs.data ^ rhs.data));

//         [MethodImpl(Inline), Op]
//         public static analog srl(analog lhs, int rhs)
//             => uint7(lhs.data >> rhs);

//         [MethodImpl(Inline), Op]
//         public static analog sll(analog lhs, int rhs)
//             => uint7(lhs.data << rhs);

//         [MethodImpl(Inline), Op]
//         public static analog inc(analog x)
//         {
//             if(x.data != analog.MaxVal)
//                 return ++x.data;
//             else
//                 return  analog.MinVal;
//         }

//         [MethodImpl(Inline), Op]
//         public static analog dec(analog src)
//         {
//             if(src.data != analog.MinVal)
//                 src.data--;
//             else
//                 src.data = analog.MaxVal;
//             return src;
//         }

//         [MethodImpl(Inline), Op]
//         public static analog hi(analog src)
//             => wrap7(src.data >> 2 & 0b11);

//         [MethodImpl(Inline), Op]
//         public static analog lo(analog src)
//             => wrap7(src.data & 0b11);

//         [MethodImpl(Inline), Op]
//         public static bit bit(analog src, int pos)
//             => pos < analog.BitWidth ? Z0.bit.test(src.data, pos) : Z0.bit.Off;

//         [MethodImpl(Inline), Op]
//         public static analog bit(analog src, int pos, bit bit)
//         {
//             if(pos < analog.BitWidth)
//                 return bit.set(src.data, (byte)pos, bit);
//             else
//                 return src;
//         }

//         [MethodImpl(Inline), Op]
//         public static ref analog bit(ref analog src, int pos, bit bit)
//         {
//             if(pos < analog.BitWidth)
//                 src.data = Z0.bit.set(src.data, (byte)pos, bit);
//             return ref src;
//         }

//         [MethodImpl(Inline)]
//         public static bool eq(analog x, analog y)
//             => x.data == y.data;

//         [MethodImpl(Inline), Op]
//         internal static byte reduce7(uint x) 
//             => (byte)(x % analog.Base);

//         [MethodImpl(Inline), Op]
//         internal static byte reduce7(int x) 
//             => (byte)((uint)x % analog.Base);

//         [MethodImpl(Inline)]
//         internal static analog wrap7(uint src) 
//             => new analog(src,false);

//         [MethodImpl(Inline)]
//         internal static analog wrap7(int src) 
//             => new analog((byte)src,false);

//         static BitFormatConfig FormatConfig7 
//             => BitFormatConfig.Limited(analog.BitWidth,analog.BitWidth);
        
//         [MethodImpl(Inline)]
//         public static string format(analog src)
//             => BitFormatter.format(src.data, FormatConfig7);

//     }
// }