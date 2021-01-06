//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class ClrQuery
    {
        /// <summary>
        /// Selects the conversion operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] ConversionOperators(this MethodInfo[] src)
            => src.Where(m => m.IsConversionOperator());

        /// <summary>
        /// Removes any conversion operations from the stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] WithoutConversionOperators(this MethodInfo[] src)
            => src.Where(m => !m.IsConversionOperator());

        /// <summary>
        /// Selects the abstract methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] Abstract(this MethodInfo[] src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the instance methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] Instance(this MethodInfo[] src)
            => src.Where(t => !t.IsStatic);

        /// <summary>
        /// Selects the non-public methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] NonPublic(this MethodInfo[] src)
            => src.Where(t => !t.IsPublic);
    }
}