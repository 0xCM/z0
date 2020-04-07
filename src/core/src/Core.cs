//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Core 
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

    }

    public static class root
    {                        
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>(T t)
            => Unsafe.SizeOf<T>()*8;            
    }

    public static partial class XTend { }
}