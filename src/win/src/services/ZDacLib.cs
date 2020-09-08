//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    using Z0.MS;

    public sealed class ZDacLib : IDisposable, IRefCountedFreeLibrary
    {
        private bool _disposed;

        private ZDac? _sos;

        internal DacDataTargetWrapper DacDataTarget { get; }

        public RefCountedFreeLibrary OwningLibrary { get; }

        internal ClrDataProcess DacInterface { get; }

        public int Release()
            => OwningLibrary.Release();

        public int AddRef()
            => OwningLibrary.AddRef();

        ZDac GetSOSInterfaceNoAddRef()
        {
            if (_sos is null)
            {
                _sos = DacInterface.GetSOSDacInterface();
                if (_sos is null)
                    throw new InvalidOperationException("This runtime does not support ISOSDac.");
            }

            return _sos.Value;
        }

        public ZDac SOSDacInterface
            => GetSOSInterfaceNoAddRef();

        // public SOSDac6? SOSDacInterface6
        //     => InternalDacPrivateInterface.GetSOSDacInterface6();

        public T GetInterface<T>(in Guid riid)
            where T : CallableCOMWrapper
        {
            IntPtr pUnknown = DacInterface.QueryInterface(riid);
            if (pUnknown == IntPtr.Zero)
                return null;

            T t = (T)Activator.CreateInstance(typeof(T), this, pUnknown)!;
            return t;
        }

        public static IntPtr TryGetDacPtr(object ix)
        {
            if (!(ix is IntPtr pUnk))
            {
                if (Marshal.IsComObject(ix))
                    pUnk = Marshal.GetIUnknownForObject(ix);
                else
                    pUnk = IntPtr.Zero;
            }

            if (pUnk == IntPtr.Zero)
                throw new ArgumentException("clrDataProcess not an instance of IXCLRDataProcess");

            return pUnk;
        }

        public ZDacLib(ProcessDataTarget dataTarget, IntPtr pClrDataProcess)
        {

            if (pClrDataProcess == IntPtr.Zero)
                throw new ArgumentNullException(nameof(pClrDataProcess));

            DacInterface = new ClrDataProcess(this, pClrDataProcess);
            DacDataTarget = new DacDataTargetWrapper(dataTarget);
        }

        public ZDacLib(ProcessDataTarget dataTarget, string dacDll)
        {

            if (dataTarget.ClrDescriptions.Length == 0)
                throw new Exception("Process is not a CLR process!");

            IntPtr dacLibrary = Windows.Kernel32.LoadLibrary(dacDll);
            if (dacLibrary == IntPtr.Zero)
                throw new Exception("Failed to load dac: " + dacLibrary);

            OwningLibrary = new RefCountedFreeLibrary(dacLibrary);

            IntPtr initAddr = NativeMethods.GetProcAddress(dacLibrary, "DAC_PAL_InitializeDLL");
            if (initAddr == IntPtr.Zero)
                initAddr = NativeMethods.GetProcAddress(dacLibrary, "PAL_InitializeDLL");

            if (initAddr != IntPtr.Zero)
            {
                IntPtr dllMain = NativeMethods.GetProcAddress(dacLibrary, "DllMain");
                if (dllMain == IntPtr.Zero)
                    throw new Exception("Failed to obtain Dac DllMain");

                DllMain main = (DllMain)Marshal.GetDelegateForFunctionPointer(dllMain, typeof(DllMain));
                main(dacLibrary, 1, IntPtr.Zero);
            }

            IntPtr addr = NativeMethods.GetProcAddress(dacLibrary, "CLRDataCreateInstance");
            if (addr == IntPtr.Zero)
                throw new Exception("Failed to obtain Dac CLRDataCreateInstance");

            DacDataTarget = new DacDataTargetWrapper(dataTarget);

            CreateDacInstance func = (CreateDacInstance)Marshal.GetDelegateForFunctionPointer(addr, typeof(CreateDacInstance));
            Guid guid = new Guid("5c552ab6-fc09-4cb3-8e36-22fa03c798b7");
            int res = func(guid, DacDataTarget.IDacDataTarget, out IntPtr iUnk);

            if (res != 0)
                throw new Exception($"Failure loading DAC: CreateDacInstance failed 0x{res:x} ClrDiagnosticsExceptionKind.DacError, res");

            DacInterface = new ClrDataProcess(this, iUnk);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool _)
        {
            if (!_disposed)
            {
                DacInterface?.Dispose();
                _sos?.Dispose();
                OwningLibrary?.Release();

                _disposed = true;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DllMain(IntPtr instance, int reason, IntPtr reserved);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int PAL_Initialize();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateDacInstance(in Guid riid, IntPtr dacDataInterface, out IntPtr ppObj);
    }
}