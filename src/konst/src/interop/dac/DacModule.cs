//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static OS;
    using static OS.Delegates;

    using EN = DacLib.DacExportNames;

    public partial struct DacLib
    {
        internal readonly struct DacExportNames
        {
            public const string DAC_PAL_InitializeDLL = nameof(DAC_PAL_InitializeDLL);

            public const string PAL_InitializeDLL = nameof(PAL_InitializeDLL);

            public const string DllMain = nameof(DllMain);

            public const string CLRDataCreateInstance = nameof(CLRDataCreateInstance);
        }

        public struct Module : IDisposable
        {
            bool Disposed;

            readonly NativeModule OwningLibrary;

            readonly IntPtr PalInitialize;

            readonly IntPtr DllMain;

            readonly IntPtr CreateDataInstance;

            [MethodImpl(Inline)]
            internal Module(NativeModule owner, IntPtr pal, IntPtr dll, IntPtr data)
            {
                Disposed = false;
                OwningLibrary = owner;
                PalInitialize = pal;
                DllMain = dll;
                CreateDataInstance = data;
            }

            public void Dispose()
            {

            }

            const string FailureCode0 = "Failed to load";

            const string FailureCode1 = "Failed to obtain Dac DllMain";

            const string FailureCode3 = "Failed to obtain Dac CLRDataCreateInstance";

            internal static Outcome<Module> create(FS.FilePath src)
            {
                var dll = LoadLibrary(src.Name);
                if (dll == IntPtr.Zero)
                    return new Outcome<Module>(address(FailureCode0));

                var owner = new NativeModule(dll);

                var pal = GetProcAddress(dll, EN.DAC_PAL_InitializeDLL);
                if (pal == IntPtr.Zero)
                    pal = GetProcAddress(dll, EN.PAL_InitializeDLL);

                if (pal != IntPtr.Zero)
                {
                    IntPtr dllMain = GetProcAddress(dll, EN.DllMain);
                    if (dllMain == IntPtr.Zero)
                    return new Outcome<Module>(address(FailureCode1));

                    DllMain main = (DllMain)Marshal.GetDelegateForFunctionPointer(dllMain, typeof(DllMain));
                    main(dll, 1, IntPtr.Zero);
                }

                var create = GetProcAddress(dll, EN.CLRDataCreateInstance);
                if (create == IntPtr.Zero)
                    return new Outcome<Module>(address(FailureCode3));

                return new Module(owner, pal, dll, create);
            }
        }
    }
}