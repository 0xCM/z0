//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static AppErrorMsg;    

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckPrimalSeq : ICheckPrimalSeq
    {
        public static ICheckPrimalSeq Checker => default(CheckPrimalSeq);
    }
    
    public interface ICheckPrimalSeq : TCheckLengths, TCheckInvariant, TCheckPrimal
    {
        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        bool ContentEqual(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)  
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        bool ContentEqual(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)  
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        bool ContentEqual(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)  
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        bool ContentEqual(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)  
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        bool ContentEqual(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)  
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        /// <summary>
        /// Asserts the equality of two boolean arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void eq(bool[] lhs, bool[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {            
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                if(lhs[i] != rhs[i])
                    throw Failed(ClaimKind.EqItem, ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        void eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(ContentEqual(lhs,rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        void eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(ContentEqual(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        void eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(ContentEqual(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        void eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(ContentEqual(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        void eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(ContentEqual(lhs, rhs), caller, file, line);
    }
}