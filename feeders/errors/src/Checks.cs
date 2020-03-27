//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Errors;
    using static AppErrorMsg;    

    public static class Checks
    {
        [MethodImpl(Inline)]
        public static IntPtr Jit(this MethodInfo src)            
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireNonGeneric(this MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireConstructed(this MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw AppErrors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
            => lhs.Count == rhs.Length ? lhs.Count : throw AppErrors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Span<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw AppErrors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw AppErrors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw AppErrors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Asserts the equality of two values via whatever equals operator is implemented
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>        
        public static bool eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of the content of two arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq<T>(T[] lhs, T[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.SequenceEqual(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        public static ClaimException failed(ClaimOpKind op, AppMsg msg)
            => ClaimException.Define(op, msg);
        
        static ClaimException failed(ClaimOpKind op, string msg, string caller, string file, int? line)
            => ClaimException.Define(op, msg, caller, file, line);

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimOpKind.Fail, AppMsg.Error(msg, caller, file,line));

        /// <summary>
        /// Fails unconditionally
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimOpKind.Fail, AppMsg.Error("failed", caller, file,line));

        /// <summary>
        /// Asserts that a set contains a specified element
        /// </summary>
        /// <param name="set">The set</param>
        /// <param name="item">The test element</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T"></typeparam>
        public static bool contains<T>(ISet<T> set, T item, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => set.Contains(item) ? true : throw  failed(ClaimOpKind.NotIn, AppMsg.Error($"Item {item} not in set"));

        /// <summary>
        /// Asserts the equality of two strings
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
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
        public static void eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => yea(lhs.ContentEqual(rhs), null, caller, file, line);

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
        public static void eq(Span<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => yea(lhs.ContentEqual(rhs), null, caller, file, line);

        /// <summary>
        /// Asserts the equality of two sets
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>        
        public static bool eq<T>(ISet<T> lhs, ISet<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.SetEquals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq<T>(Vector128<T> lhs, Vector128<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool eq<T>(Vector256<T> lhs, Vector256<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));


        /// <summary>
        /// Asserts the equality of two boolean arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void eq(bool[] lhs, bool[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
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
        public static void eq(bool lhs, bool rhs)
            => (lhs == rhs).IfNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));

        public static bool eq(HexByteKind lhs, HexByteKind rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(ByteKind lhs, ByteKind rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(int lhs, int rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, AppMsg.Define(msg, AppMsgKind.Error, caller, file, line));

        public static bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimOpKind.NEq, Equal(lhs, rhs, caller, file, line));

        public static bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        public static bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        public static bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        /// <summary>
        /// Asserts content equality for two spans with structured equatable content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
        {            
            if(!lhs.SequenceEqual(rhs))
            {
                for(var i = 0; i< length(lhs,rhs); i++)
                    if(!lhs[i].Equals(rhs[i]))
                        AppErrors.ThrowNotEqualNoCaller(lhs[i], rhs[i]);
            }
        }

        /// <summary>
        /// Asserts content equality for two spans with structured equatable content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<T>(Span<T> lhs, Span<T> rhs)
            where T : struct, IEquatable<T>
        {
            if(!lhs.SequenceEqual(rhs))
            {
                for(var i = 0; i< length(lhs,rhs); i++)
                    if(!lhs[i].Equals(rhs[i]))
                        AppErrors.ThrowNotEqualNoCaller(lhs[i], rhs[i]);
            }
        }

        public static bool neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, Equal(lhs, rhs, caller, file, line));
        
        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be true</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void yea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.IfNone(() => throw ClaimException.Define(NotTrue(msg, caller, file,line)));

        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be true</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void yea<T>(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => src.IfNone(() => throw ClaimException.Define(NotTrue($"{typeof(T).NumericKind().Format()}" + (msg ?? string.Empty) , caller, file, line)));

        /// <summary>
        /// Asserts the operand is false
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void nea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.IfSome(() => throw ClaimException.Define(NotFalse(msg, caller, file,line)));

        /// <summary>
        /// Asserts the pointer is not null
        /// </summary>
        /// <param name="p">The pointer to check</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static unsafe void notnull(void* p, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null).IfNone(() => throw new ArgumentNullException(AppMsg.Define($"Pointer was null", AppMsgKind.Error, caller,file,line).ToString()));

        public static bool notnull<T>(T src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", AppMsgKind.Error, caller,file,line).ToString());

        public static void exists(FilePath path,[Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => path.Exists().IfNone(() => throw AppException.Define($"The file {path} does not exist", caller, file,line));

        public static void exists(FolderPath path,[Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => path.Exists().IfNone(() => throw AppException.Define($"The folder {path} does not exist", caller, file,line));
    }
}