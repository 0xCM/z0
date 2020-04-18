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

    using static Seed;
    using static AppErrorMsg;    
    
    public readonly struct Claim : ICheck<Claim>
    {
        public static ICheck<Claim> Checker => default(Claim);
        
        [MethodImpl(Inline)]   
        public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]   
        public static int length<T>(T[] lhs, T[] rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]   
        public static int length<T>(Span<T> lhs, Span<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireNonGeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireConstructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="op">The kind of claim that failed</param>
        /// <param name="msg">The failure description</param>
        public static ValidityException failed(ValidityClaim op, IAppMsg msg)
        {
            require(msg != null, $"Defining validity exceptions with invalid messages is bad");
            return ValidityException.Define(op, msg);
        }

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ValidityClaim.Fail, AppMsg.Error(msg, caller, file,line));

        /// <summary>
        /// Fails unconditionally
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ValidityClaim.Fail, AppMsg.Error("failed", caller, file,line));

        [MethodImpl(Inline)]   
        public static bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(int lhs, int rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, AppMsg.Define(msg, AppMsgKind.Error, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ValidityClaim.NEq, Equal(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]   
        public static bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool require(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => invariant ? true : throw failed(ValidityClaim.Invariant, InvariantFailure(caller, file, line));

        [MethodImpl(Inline)]
        public static bool require(bool invariant, AppMsg msg)
            => invariant ? true : throw failed(ValidityClaim.Invariant, msg);

        [MethodImpl(Inline)]
        public static bool no(bool invariant, AppMsg msg)
            => !invariant ? true : throw failed(ValidityClaim.False, msg);

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(sbyte lhs, sbyte rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ValidityClaim.Eq, msg);

        [MethodImpl(Inline)]
        internal static ulong dist(double a, double b)
            => a >= b ? (ulong)(a - b) : (ulong)(b - a);

        [MethodImpl(Inline)]
        internal static double relerr(double lhs, double rhs)
        {
            var err = dist(lhs,rhs)/lhs;
            return double.IsNaN(err) ? 0 : err;
        }

        [MethodImpl(Inline)]
        internal static bool within(double a, double b, double delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;

        public static bool almost(float lhs, float rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var err = relerr(lhs,rhs);
            var tolerance = .1f;            
            return err < tolerance ? true : throw failed(ValidityClaim.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
        }

        public static bool almost(double lhs, double rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var err = relerr(lhs,rhs);
            var tolerance = .1f;            
            return err < tolerance ? true : throw failed(ValidityClaim.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
        }

        /// <summary>
        /// Asserts the pointer is not null
        /// </summary>
        /// <param name="p">The pointer to check</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static unsafe void notnull(void* p, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null).OnNone(() => throw new ArgumentNullException(AppMsg.Define($"Pointer was null", AppMsgKind.Error, caller,file,line).ToString()));

        public static bool notnull<T>(T src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", AppMsgKind.Error, caller,file,line).ToString());

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
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                if(lhs[i] != rhs[i])
                    throw failed(ValidityClaim.EqItem, ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
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
        [MethodImpl(Inline)]
        public static void eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(lhs.ContentEqual(rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(ContentEqual(lhs, rhs), caller, file, line);

        public static void exists(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => path.Exists().OnNone(() => throw AppException.Define($"The file {path} does not exist", caller, file,line));

        public static void exists(FolderPath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => path.Exists().OnNone(() => throw AppException.Define($"The folder {path} does not exist", caller, file,line));

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
            => set.Contains(item) ? true : throw  failed(ValidityClaim.NotIn, AppMsg.Error($"Item {item} not in set"));

        /// <summary>
        /// Asserts the equality of two sets
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>        
        public static bool seteq<T>(ISet<T> lhs, ISet<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.SetEquals(rhs) ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool veq<T>(Vector128<T> lhs, Vector128<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => lhs.Equals(rhs) ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static bool veq<T>(Vector256<T> lhs, Vector256<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => lhs.Equals(rhs) ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));
                
        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        static bool ContentEqual(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)  
        {
            var count = Claim.length(lhs,rhs);
            for(var i=0; i<count; i++)
                if(refs.skip(lhs, i) != refs.skip(rhs, i))
                    return false;
            return true;
        }      

        public static void yea<T>(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => src.OnNone(() => throw ValidityException.Define(NotTrue($"{typeof(T).NumericKind().Format()}" + (msg ?? string.Empty) , caller, file, line)));

        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void yea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.OnNone(() => throw ValidityException.Define(NotTrue(msg, caller, file,line)));

        /// <summary>
        /// Asserts the operand is false
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void nea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.OnSome(() => throw ValidityException.Define(NotFalse(msg, caller, file,line)));

        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!object.Equals(lhs,rhs))
                throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            

        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(object.Equals(lhs,rhs))
                throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            
    }
}