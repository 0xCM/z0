//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class gfp
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Sign signum<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return fmath.signum(float64(src));
            else            
                throw unsupported<T>();
        }           
    }

    partial class fmath
    {
        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline), Op]
        public static Sign signum(float src)
            => (Sign)MathF.Sign(src);

        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline), Op]
        public static Sign signum(double src)
            => (Sign)Math.Sign(src);            
    }
}
