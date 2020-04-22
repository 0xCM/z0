//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static Structured;

    using K = Kinds;

    public interface ICheckSVF<T> : ICheckSF
        where T : unmanaged
    {   
        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        int CellCount<W>(W w = default)
            where W : struct, ITypeWidth
                => ((int)default(W).TypeWidth)/BitSize.measure<T>();

       void Run<W>(ISFuncApi f, Action act, W width, K.OperatorClass c)
            where W : unmanaged, ITypeWidth
        {
            var succeeded = true;
            var casename = Context.CaseName<W,T>(f);
            var clock = time.counter();

            clock.Start();
            try
            {
                act();
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,clock);
            }
        }
 
        /// <summary>
        /// Validates a 128-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Decompose<F>(F f, K.UnaryOpClass op, W128 w)
            where F : ISVUnaryOp128DApi<T>;


        /// <summary>
        /// Validates a 256-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Decompose<F>(F f, K.UnaryOpClass op, W256 w)
            where F : ISVUnaryOp256DApi<T>;

        /// <summary>
        /// Validates a 128-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Decompose<F>(F f, K.BinaryOpClass op, W128 w)
            where F : ISVBinaryOp128DApi<T>;

        /// <summary>
        /// Validates a 256-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void Decompose<F>(F f, K.BinaryOpClass op, W256 w)
            where F : ISVBinaryOp256DApi<T>;
        
    }

}