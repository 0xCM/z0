//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static ClrDataModel;

    internal static class DebugOnly
    {

        public static unsafe ulong AsPointer(this Span<byte> span)
        {
            DebugOnly.Assert(span.Length >= IntPtr.Size);
            DebugOnly.Assert(unchecked((int)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span))) % IntPtr.Size == 0);
            return IntPtr.Size == 4
                ? Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span))
                : Unsafe.As<byte, ulong>(ref MemoryMarshal.GetReference(span));
        }

        public static unsafe int AsInt32(this Span<byte> span)
        {
            DebugOnly.Assert(span.Length >= sizeof(int));
            DebugOnly.Assert(unchecked((int)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span))) % sizeof(int) == 0);
            return Unsafe.As<byte, int>(ref MemoryMarshal.GetReference(span));
        }

        public static unsafe uint AsUInt32(this Span<byte> span)
        {
            DebugOnly.Assert(span.Length >= sizeof(uint));
            DebugOnly.Assert(unchecked((int)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span))) % sizeof(uint) == 0);
            return Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span));
        }

        public static string GetName(this ClrRootKind kind) 
            => kind switch
        {
            ClrRootKind.None => "none",
            ClrRootKind.FinalizerQueue => "finalization root",
            ClrRootKind.StrongHandle => "strong handle",
            ClrRootKind.PinnedHandle => "pinned handle",
            ClrRootKind.Stack => "stack root",
            ClrRootKind.RefCountedHandle => "ref counted handle",
            ClrRootKind.AsyncPinnedHandle => "async pinned handle",
            ClrRootKind.SizedRefHandle => "sized ref handle",
            _ => "unknown root"
        };

        [Conditional("DEBUG")]
        public static void Assert(bool mustBeTrue) 
            => Assert(mustBeTrue, "Assertion Failed");

        [Conditional("DEBUG")]
        public static void Assert(bool mustBeTrue, string msg)
        {
            if (!mustBeTrue)
                Fail(msg);
        }

        [Conditional("DEBUG")]
        public static void Fail(string message)
        {
            throw new AssertionException(message);
        }
    
    }

    #pragma warning disable CA1032 // Implement standard exception constructors
    #pragma warning disable CA1064 // Exceptions should be public
    internal sealed class AssertionException : Exception
    {
        public AssertionException(string msg)
            : base(msg)
        {
        }
    }
}