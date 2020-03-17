//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using NC = NumericClass;

    public enum NumericClassId : byte
    {
        /// <summary>
        /// The nonidentifing identifier
        /// </summary>
        None = 0,

        /// <summary>
        /// Identifies the 8-bit unsigned integer type
        /// </summary>
        Int8u = NC.Int8u,       

        /// <summary>
        /// Identifies the 16-bit unsigned integer type
        /// </summary>
        Int16u = NC.Int16u,       

        /// <summary>
        /// Identifies the 32-bit unsigned integer type
        /// </summary>
        Int32u = NC.Int32u,

        /// <summary>
        /// Identifies the 64-bit unsigned integer type
        /// </summary>
        Int64u = NC.Int64u,

        /// <summary>
        /// Identifies the 8-bit signed integer type
        /// </summary>
        Int8i = NC.Int8i,       

        /// <summary>
        /// Identifies the 16-bit signed integer type
        /// </summary>
        Int16i = NC.Int16i,       

        /// <summary>
        /// Identifies the 32-bit signed integer type
        /// </summary>
        Int32i = NC.Int32i,       

        /// <summary>
        /// Identifies the 64-bit signed integer type
        /// </summary>
        Int64i = NC.Int64i,       

        /// <summary>
        /// Identifies the 32-bit floating-point type
        /// </summary>
        Float32 = NC.Float32,

        /// <summary>
        /// Identifies the 64-bit floating-point type
        /// </summary>
        Float64 = NC.Float64,
    }
}