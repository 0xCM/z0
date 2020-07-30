//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;

    using Z0.MS;

    /// <summary>
    /// A frame in a managed stack trace.  Note you can call ToString on an instance of this object to get the
    /// function name (or clr!Frame name) similar to SOS's !clrstack output.
    /// </summary>
    public abstract class ClrStackFrame
    {
        /// <summary>
        /// The thread parent of this frame.  Note that this may be null when inspecting the stack of ClrExceptions.
        /// </summary>
        public abstract ClrThread Thread { get; }

        /// <summary>
        /// Gets this stack frame context.
        /// </summary>
        public abstract ReadOnlySpan<byte> Context { get; }

        /// <summary>
        /// Gets the instruction pointer of this frame.
        /// </summary>
        public abstract ulong InstructionPointer { get; }

        /// <summary>
        /// Gets the stack pointer of this frame.
        /// </summary>
        public abstract ulong StackPointer { get; }

        /// <summary>
        /// Gets the type of frame (managed or internal).
        /// </summary>
        public abstract ClrStackFrameKind Kind { get; }

        /// <summary>
        /// Gets the <see cref="ClrMethod"/> which corresponds to the current stack frame.  This may be <see langword="null"/> if the
        /// current frame is actually a CLR "Internal Frame" representing a marker on the stack, and that
        /// stack marker does not have a managed method associated with it.
        /// </summary>
        public abstract ClrMethod Method { get; }

        /// <summary>
        /// Gets the helper method frame name if <see cref="Kind"/> is <see cref="ClrStackFrameKind.Runtime"/>, <see langword="null"/> otherwise.
        /// </summary>
        public abstract string FrameName { get; }
    }

}