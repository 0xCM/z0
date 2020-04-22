//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct BlockChecks : ICheckBlocks
    {
        public static ICheckBlocks Checker => default(BlockChecks);
    }
    
    public interface ICheckBlocks : ICheckNumeric
    {
        /// <summary>
        /// Asserts content equality for two 128-bit blocks
        /// </summary>
        /// <param name="xb">The left span</param>
        /// <param name="yb">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        void eq<T>(Block128<T> lhs, Block128<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< lhs.CellCount; i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw AppErrors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two 256-bit blocks
        /// </summary>
        /// <param name="xb">The left block</param>
        /// <param name="yb">The right block</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        void eq<T>(Block256<T> xb, Block256<T> yb, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            for(var i = 0; i< Blocks.length(xb,yb); i++)
                if(!gmath.eq(xb[i],yb[i]))
                    throw AppErrors.ItemsNotEqual(i, xb[i], yb[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two 512-bit blocks
        /// </summary>
        /// <param name="xb">The left block</param>
        /// <param name="yb">The right block</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        void eq<T>(Block512<T> xb, Block512<T> yb, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            for(var i = 0; i< Blocks.length(xb,yb); i++)
                if(!gmath.eq(xb[i],yb[i]))
                    throw AppErrors.ItemsNotEqual(i, xb[i], yb[i], caller, file, line);
        }         
    }
}