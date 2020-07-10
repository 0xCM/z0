//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Returns 0 in a box
        /// </summary>
        /// <param name="kind">The numeric kind of 0 to be put into the box</param>
        [MethodImpl(Inline)]
        public static BoxedNumber BoxedZero(this NumericKind kind)
            => BoxedNumber.Define(z.rebox(byte.MinValue, kind), kind); 

        /// <summary>
        /// Puts a value of any numeric kind into a box of any numeric kind
        /// </summary>
        /// <param name="dst">The target box kind</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<T>(this NumericKind dst, T src)
            where T : unmanaged
                => BoxedNumber.Define(z.rebox(src,dst), dst);
        
        /// <summary>
        /// Puts an enum value into a (numeric) box
        /// </summary>
        /// <param name="e">The enumeration value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<E>(this E src)
            where E : unmanaged, Enum            
                => BoxedNumber.From(src);

        [MethodImpl(Inline)]        
        public static bool LiberalEquals(this BoxedNumber lhs, BoxedNumber rhs)
        {
            if(lhs.IsSignedInt && rhs.IsSignedInt)
                return lhs.Convert<long>() == rhs.Convert<long>();
            else if(lhs.IsUnsignedInt && rhs.IsUnsignedInt)
                return lhs.Convert<ulong>() == rhs.Convert<ulong>();
            else if(lhs.IsFloat && rhs.IsFloat)
                return lhs.Convert<double>() == rhs.Convert<double>();
            else   
                return false;
        }
   }
}