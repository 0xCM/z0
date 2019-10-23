//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class ExprX
    {
        [MethodImpl(Inline)]
        static VariableExpr<T> Assign<T>(this VariableExpr<T> v, ITypedExpr<T> value)
            where T : unmanaged
        {
            if(value != null)
                v.Set(value);
            return v;
        }

        [MethodImpl(Inline)]
        static VariableExpr<T> Assign<T>(this VariableExpr<T> v, T value)
            where T : unmanaged
        {
            v.Set(value);
            return v;
        }
        
        /// <summary>
        /// Returns the source expression variable at index 0
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N1,T> src)
            where T : unmanaged
                => src.Vars[0];

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N1,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N1,T> src, T value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 0
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N2,T> src)
            where T : unmanaged
                => src.Vars[0];

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N2,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N2,T> src, T value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 1
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N2,T> src)
            where T : unmanaged
                => src.Vars[1];

        /// <summary>
        /// Returns the source expression variable at index 1, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N2,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var1().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 1, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N2,T> src, T value)
            where T : unmanaged
                => src.Var1().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 0
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N3,T> src)
            where T : unmanaged
                => src.Vars[0];

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N3,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 0, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var0<T>(this VariedExpr<N3,T> src, T value)
            where T : unmanaged
                => src.Var0().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 1
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N3,T> src)
            where T : unmanaged
                => src.Vars[1];

        /// <summary>
        /// Returns the source expression variable at index 1, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N3,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var1().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 1, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var1<T>(this VariedExpr<N3,T> src, T value)
            where T : unmanaged
                => src.Var1().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 2
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var2<T>(this VariedExpr<N3,T> src)
            where T : unmanaged
                => src.Vars[2];

        /// <summary>
        /// Returns the source expression variable at index 2, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var2<T>(this VariedExpr<N3,T> src, ITypedExpr<T> value)
            where T : unmanaged
                => src.Var2().Assign(value);

        /// <summary>
        /// Returns the source expression variable at index 2, optionally assigned to supplied value
        /// </summary>
        /// <param name="src">The source expression</param>
        /// <param name="value">The value, if any, to assign the variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariableExpr<T> Var2<T>(this VariedExpr<N3,T> src, T value)
            where T : unmanaged
                => src.Var2().Assign(value);

    }

}
