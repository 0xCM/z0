//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    public static class BoxedNumberExtensions
    {
        [MethodImpl(Inline)]
        public static BoxedNumber Zero(this NumericKind kind)
            => BoxedNumber.Define(Converter.oconvert(byte.MinValue, kind), kind); 

        /// <summary>
        /// Puts a value of any numeric kind into a box of any numeric kind
        /// </summary>
        /// <param name="dst">The target box kind</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<T>(this NumericKind dst, T src)
            where T : unmanaged
                => BoxedNumber.Define(Converter.oconvert(src,dst), dst);

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