//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Kinds
    {   
        /// <summary>
        /// Specifies the non-parametric A0 representative
        /// </summary>         
        public static A0 A0 => default;

        /// <summary>
        /// Specifies the non-parametric A1 representative
        /// </summary>         
        public static A1 A1 => default;

        /// <summary>
        /// Specifies the non-parametric A2 representative
        /// </summary>         
        public static A2 A2 => default;
        
        /// <summary>
        /// Specifies the non-parametric A3 representative
        /// </summary>         
        public static A3 A3 => default;

        /// <summary>
        /// Creates a T-parametric A0 representative
        /// </summary>
        /// <typeparam name="T">The type by which a classified operation is parameterized</typeparam>
        public static A0<T> nullary<T>() 
            where T : unmanaged => default;

        /// <summary>
        /// Creates a T-parametric A1 representative
        /// </summary>
        /// <typeparam name="T">The type by which a classified operation is parameterized</typeparam>
        public static A1<T> unary<T>() 
            where T : unmanaged => default;

        /// <summary>
        /// Creates a T-parametric A2 representative
        /// </summary>
        /// <typeparam name="T">The type by which a classified operation is parameterized</typeparam>
        public static A2<T> binary<T>() 
            where T : unmanaged => default;

        /// <summary>
        /// Creates a T-parametric A3 representative
        /// </summary>
        /// <typeparam name="T">The type by which a classified operation is parameterized</typeparam>
        public static A3<T> ternary<T>() 
            where T : unmanaged => default;
    }
}