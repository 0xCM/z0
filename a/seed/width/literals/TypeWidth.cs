//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using FW = DataWidth;

    /// <summary>
    /// Defines a <see cref="FixedWidth"/> subset that is constrained to widths 
    /// that correspond to data type widths suported by type-systems and native OS/hardware types
    /// </summary>
    /// <remarks>
    /// The selected subset is clearly biased towards x86 OS/sytem architectures
    /// </remarks>
    public enum TypeWidth : uint
    {
        /// <summary>
        /// Clasifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a bit-width of 1
        /// </summary>
        /// <remarks>
        /// Ok, this one is synthetic; but it is useful to pretend that the type system
        /// supports 1-bit types
        /// </remarks>
        W1 = FW.W1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = FW.W8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = FW.W16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = FW.W32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = FW.W64,

        /// <summary>
        /// Indicates a bit-width of 128
        /// </summary>
        W128 = FW.W128,

        /// <summary>
        /// Indicates a bit-width of 256
        /// </summary>
        W256 = FW.W256,

        /// <summary>
        /// Indicates a bit-width of 512
        /// </summary>
        W512 = FW.W512,

        /// <summary>
        /// Indicates a bit-width of 1024
        /// </summary>
        W1024 = FW.W1024,

    }
}