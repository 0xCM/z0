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
    using static ClrTables;
    using static z;

    partial struct DacLib
    {
        public readonly struct Fx
        {
            [UnmanagedFunctionPointer(StdCall)]
            public delegate int DacGetFieldData(IntPtr self, ulong addr, out FieldData data);
        }

        public class TableFunctions : IDisposable
        {
            Fx.DacGetFieldData _GetFieldData;

            static void init<T>(ref T t, IntPtr entry)
                where T : Delegate
            {
                if (t != null)
                    return;

                t = (T)Marshal.GetDelegateForFunctionPointer(entry, typeof(T));
            }

            IntPtr[] Pointers;

            public TableFunctions()
            {
                Pointers = sys.alloc<IntPtr>(256);
                var target = span(Pointers);
                ref var dst = ref first(target);
                var i = 0u;
                init(ref _GetFieldData, skip(dst,i++));
            }

            public void Dispose()
            {

            }

            [MethodImpl(Inline)]
            public static bool ok(int hresult)
                => hresult >= 0;
        }
    }
}