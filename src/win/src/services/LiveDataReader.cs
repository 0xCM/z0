//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    using Z0.Dac;
    using Z0.MS;

    public class ProcessReaderException : Exception
    {
        public ProcessReaderException(string pattern, params object[] src)
            : base(text.format(pattern,src))
        {

        }
    }

    static class ProcessDataReaderX
    {
        public static IntPtr AsIntPtr(this ulong address)
        {
            if (IntPtr.Size == 8)
                return new IntPtr((long)address);

            return new IntPtr((int)address);
        }

        public static unsafe ulong AsPointer(this Span<byte> span)
        {
            return IntPtr.Size == 4
                ? Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span))
                : Unsafe.As<byte, ulong>(ref MemoryMarshal.GetReference(span));
        }

        public static unsafe int AsInt32(this Span<byte> span)
            => Unsafe.As<byte, int>(ref MemoryMarshal.GetReference(span));

        public static unsafe uint AsUInt32(this Span<byte> span)
            => Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span));
    }


}