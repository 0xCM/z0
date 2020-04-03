namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using C = OpClass;

    /// <summary>
    /// Characterizes a vectorized sfunc decomposition validator
    /// </summary>
    /// <typeparam name="T">The vector cell type</typeparam>
    public interface ISVFDecomposer<T> : ISFValidator<T>
        where T : unmanaged
    {   
        /// <summary>
        /// Validates a 128-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Validate<F>(F f, C.UnaryOp op, W128 w)
            where F : ISVUnaryOp128DApi<T>;   

        /// <summary>
        /// Validates a 256-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Validate<F>(F f, C.UnaryOp op, W256 w)
            where F : ISVUnaryOp256DApi<T>;

        /// <summary>
        /// Validates a 128-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Validate<F>(F f, C.BinaryOp op, W128 w)
            where F : ISVBinaryOp128DApi<T>;

        /// <summary>
        /// Validates a 256-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Validate<F>(F f, C.BinaryOp op, W256 w)
            where F : ISVBinaryOp256DApi<T>;
    }

    public interface ISVFDecomposer : ISFValidator
    {
        void CheckUnaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>;

        void CheckUnaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>;                

        void CheckShiftOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>;

        void CheckShiftOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>;

        void CheckBinaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;            

        void CheckBinaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckTernaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>;

        void CheckTernaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>;

        void CheckMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;    
            
        void CheckMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
                    where T : unmanaged
                    where F : ISVBinaryOp128Api<T>;

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>;
    }
}