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
        public static T As<T>(this bit b)
            where T : unmanaged
                => convert<T>((uint)b);


        [MethodImpl(Inline)]
        public static bit ToBit(this bool x)
            => x;

        [MethodImpl(Inline)]
        public static bit ToBit<T>(this T x)
            where T : unmanaged
                => gmath.neq(x,default);
        
        /// <summary>
        /// Assigns a random value to a variable and returns that value to the caller
        /// </summary>
        /// <param name="v">The variable to set</param>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Set<T>(this VariableExpr<T> v, IPolyrand random)
            where T : unmanaged
        {
            var x = random.Next<T>();
            v.Assign(x);
            return x;
        }

        /// <summary>
        /// Assigns a random value to a variable and returns that value to the caller
        /// </summary>
        /// <param name="v">The variable to set</param>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive min value to assign</param>
        /// <param name="max">The exclusive max value to assign</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Set<T>(this VariableExpr<T> v, IPolyrand random, T min, T max)
            where T : unmanaged
        {
            var x = random.Next<T>(min,max);
            v.Assign(x);
            return x;
        }

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
