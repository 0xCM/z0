//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    
    partial class Cmd
    {        
        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<byte> bytes(in Vector128<byte> src)
            => Fixed.view<byte>(Fixed.from(src.WithElement(15,Zero8u)));        

        /// <summary>
        /// Defines a command from data supplied by a 128-bit intrinsic vector
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Command define(Vector128<byte> src)
            => new Command(src);

        [MethodImpl(Inline), Op]
        internal static ulong write(byte count, ulong dst)
            => dst | (ulong)count << 56;

        /// <summary>
        /// Defines a command from data supplied by 2 64-bit unsigned integers
        /// </summary>
        /// <param name="lo">The lo bytes</param>
        /// <param name="hi">The hi bytes</param>
        [MethodImpl(Inline), Op]
        public static Command define(ulong lo, ulong hi)
            => new Command(v8u(Vector128.Create(lo,hi)));    

        /// <summary>
        /// Creates a command from data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="data">The data source</param>
        [MethodImpl(Inline), Op]
        public static Command define(ulong data)
            => new Command(v8u(Vector128.Create(data, write(Bits.effsize(data),0ul))));

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="data">The data source</param>
        [MethodImpl(Inline), Op]
        public static Command define(uint data)
            => new Command(v8u(Vector128.Create((ulong)data, write(Bits.effsize(data),0ul))));

    }
}