//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static ErrorMessages;
    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Claim
    {
        public static ClaimException failed(ClaimOpKind op, AppMsg msg)
            => ClaimException.Define(op, msg);
        
        static ClaimException failed(ClaimOpKind op, string msg, string caller, string file, int? line)
            => ClaimException.Define(op, msg, caller, file, line);

        /// <summary>
        /// Fails unconditionally
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void fail(string msg, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimOpKind.Fail, AppMsg.Error(msg, caller, file,line));

        /// <summary>
        /// Asserts the equality of two enum values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq(Enum lhs, Enum rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true
                : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts that a set contains a specified element
        /// </summary>
        /// <param name="set">The set</param>
        /// <param name="item">The test element</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T"></typeparam>
        public static bool contains<T>(ISet<T> set, T item, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => set.Contains(item) ? true : throw  failed(ClaimOpKind.NotIn, AppMsg.Error($"Item {item} not in set"));

        /// <summary>
        /// Asserts the equality of two strings
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq(string lhs, string rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));


        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.yea(lhs.ContentEqual(rhs), null, caller, file, line);

        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void eq(Span<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.yea(lhs.ContentEqual(rhs), null, caller, file, line);

        /// <summary>
        /// Asserts the equality of two values via whatever equals operator is implemented
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of the content of two arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq<T>(T[] lhs, T[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Eq(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two boolean arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void eq(bool[] lhs, bool[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(lhs[i] != rhs[i])
                    throw failed(ClaimOpKind.EqItem, ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        /// <summary>
        /// Asserts the equality of two boolean values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq(bool lhs, bool rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two bit values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq(bit lhs, bit rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(byte lhs, byte rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(sbyte lhs, sbyte rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(short lhs, short rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(ushort lhs, ushort rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(int lhs, int rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(int lhs, int rhs, string msg, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, AppMsg.Define(msg, SeverityLevel.Error, caller, file, line));

        public static bool eq(uint lhs, uint rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool neq(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimOpKind.NEq, Equal(lhs, rhs, caller, file, line));

        public static bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool numeq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => gmath.eq(lhs,rhs) ? true : throw Errors.Equal(lhs,rhs);

        /// <summary>
        /// Asserts content equality for two spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        public static void eq<T>(Span<T> lhs, Span<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two natural spans of coincident length
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<N,T>(NatBlock<N,T> lhs, NatBlock<N,T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
            where N : unmanaged, ITypeNat             
                => eq(lhs.Unsized,rhs.Unsized, caller,file,line);

        /// <summary>
        /// Asserts content equality for two tabular spans of coincident dimension
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<M,N,T>(NatGrid<M,N,T> lhs, NatGrid<M,N,T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged 
                => eq(lhs.Data,rhs.Data, caller, file, line);

        /// <summary>
        /// Asserts content equality for two 128-bit blocked spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void eq<T>(ConstBlock128<T> lhs, ConstBlock128<T> rhs,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< Block128.length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two 128-bit blocked spans
        /// </summary>
        /// <param name="xb">The left span</param>
        /// <param name="yb">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void eq<T>(Block128<T> xb, Block128<T> yb, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => eq(xb.ReadOnly(), yb.ReadOnly(), caller,file,line);

        /// <summary>
        /// Asserts content equality for two 256-bit blocked spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void eq<T>(Block256<T> lhs, Block256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts that corresponding elements of two source spans of the same length are "close" as determined by a specified tolerance
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="tolerance">The acceptable difference between corresponding left/right elements</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void close<T>(Span<T> lhs, Span<T> rhs, T tolerance, Action<int,T,T> handler,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                {
                    handler(i, lhs[i], rhs[i]);
                    break;                    
                }  
        }

        /// <summary>
        /// Asserts that corresponding elements of two source spans of the same length are "close" as determined by a specified tolerance
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="tolerance">The acceptable difference between corresponding left/right elements</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void close<T>(this Span<T> lhs, Span<T> rhs, T tolerance, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        public static bool neq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, Equal(lhs, rhs, caller, file, line));
        
        /// <summary>
        /// Asserts that an interval contains a specified point
        /// </summary>
        /// <param name="range">The interval</param>
        /// <param name="x">The test point</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool contains<T>(Interval<T> range, T x, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => range.Contains(x) ? true : throw failed(ClaimOpKind.Between, NotBetween(x,range.Left, range.Right, caller, file, line));

        /// <summary>
        /// Asserts that a value is between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x">The value to test</param>
        /// <param name="lhs">The lower bound</param>
        /// <param name="rhs">The uper bound</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool between<T>(T x, T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.between(x,lhs,rhs) ? true : throw failed(ClaimOpKind.Between, NotBetween(x, lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts that the left value is larger than the right value
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool gt<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw failed(ClaimOpKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts that the left value is larger or equal to the right value
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool gteq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gteq(lhs,rhs) ? true : throw failed(ClaimOpKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts that the left value is smaller than the right value
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool lt<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lt(lhs,rhs) ? true : throw failed(ClaimOpKind.Lt, NotLessThan(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts that the left value is smaller or equal to the right value
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool lteq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lteq(lhs,rhs) ? true : throw failed(ClaimOpKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts that the source value is nonzero
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool nonzero<T>(T x, [Member] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => gmath.nonzero(x) ? true : throw Errors.NotNonzero(caller,file,line);

        /// <summary>
        /// Asserts that the source value is zero
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static bool zero<T>(T x, [Member] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => !gmath.nonzero(x) ? true : throw Errors.NotNonzero(caller,file,line);

        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be true</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool yea(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => src ? true : throw ClaimException.Define(NotTrue(msg, caller, file,line));

        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be true</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool yea<T>(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
            => src ? true : throw ClaimException.Define(NotTrue($"{moniker<T>() }" + (msg ?? string.Empty) , caller, file,line));

        /// <summary>
        /// Asserts the operand is false
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool nea(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !src ? true : throw ClaimException.Define(NotFalse(msg, caller, file,line));

        /// <summary>
        /// Asserts the pointer is not null
        /// </summary>
        /// <param name="p">The pointer to check</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static unsafe bool notnull(void* p, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null) ? true : throw new ArgumentNullException(AppMsg.Define($"Pointer was null", SeverityLevel.Error, caller,file,line).ToString());

        public static bool notnull<T>(T src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", SeverityLevel.Error, caller,file,line).ToString());
    }
}