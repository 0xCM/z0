//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using Microsoft.Win32.SafeHandles;
    using System.Collections.Immutable;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using System.Linq;
    using System.Diagnostics;
    using System.Buffers;
    using System.Text;
    using System.IO;
    using System.Collections.Generic;

    using Z0.Image;

    using static ClrDataModel;
    using static MsD;

    public sealed unsafe class SOSHandleEnum : CallableCOMWrapper
    {
        private static readonly Guid IID_ISOSHandleEnum = new Guid("3E269830-4A2B-4301-8EE2-D6805B29B2FA");

        private readonly Next _next;

        public SOSHandleEnum(DacLibrary library, IntPtr pUnk)
            : base(library?.OwningLibrary, IID_ISOSHandleEnum, pUnk)
        {
            ref readonly ISOSHandleEnumVTable vtable = ref Unsafe.AsRef<ISOSHandleEnumVTable>(_vtable);
            InitDelegate(ref _next, vtable.Next);
        }

        public int ReadHandles(HandleData[] handles)
        {
            if (handles is null)
                throw new ArgumentNullException(nameof(handles));

            fixed (HandleData* ptr = handles)
            {
                int hr = _next(Self, handles.Length, ptr, out int read);
                return hr >= S_OK ? read : 0;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Next(
            IntPtr self,
            int count,
            HandleData* handles,
            out int pNeeded);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct ISOSHandleEnumVTable
    {
        private readonly IntPtr Skip;
        private readonly IntPtr Reset;
        private readonly IntPtr GetCount;
        public readonly IntPtr Next;
    } 
}