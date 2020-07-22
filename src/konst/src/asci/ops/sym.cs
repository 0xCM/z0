//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct asci
    {
        /// <summary>
        /// Computes the source digit's symbol value
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static BinarySym symval(BinaryDigit src)
            => symbol(src).Value;

        /// <summary>
        /// Computes the source digit's symbol value
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static OctalSym symval(OctalDigit src)
            => symbol(src).Value;            

        /// <summary>
        /// Computes the source digit's symbol value
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static DecimalSym symval(DecimalDigit src)
            => symbol(src).Value;

        /// <summary>
        /// Computes the source digit's symbol value
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static HexSym symval(LowerCased @case, HexDigit src)
            => symbol(@case,src).Value;                        

        /// <summary>
        /// Computes the source digit's symbol value
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static HexSym symval(UpperCased @case, HexDigit src)
            => symbol(@case,src).Value;                        
    }
}