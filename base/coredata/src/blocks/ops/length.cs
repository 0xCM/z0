//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Returns the length of 32-bit blocked containers of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Block16<S> lhs, in Block16<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of 32-bit const blocked containers of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in ConstBlock16<S> lhs, in ConstBlock16<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of 32-bit blocked containers of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Block32<S> lhs, in Block32<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of 32-bit const blocked containers of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in ConstBlock32<S> lhs, in ConstBlock32<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Block64<S> lhs, in Block64<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in ConstBlock64<S> lhs, in ConstBlock64<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Block128<S> lhs, in Block128<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in ConstBlock128<S> lhs, in ConstBlock128<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in Block256<S> lhs, in Block256<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(in ConstBlock256<S> lhs, in ConstBlock256<T> rhs)
            where S : unmanaged
            where T : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : badsize<int>(lhs.CellCount,rhs.CellCount);
    }
}