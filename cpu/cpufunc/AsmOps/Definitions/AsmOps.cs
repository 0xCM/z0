//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    public static partial class AsmOps
    {     
        static AsmOps()
        {                            

            rand32uBytes.Liberate();            
        }

        static ReadOnlySpan<byte> rand32uBytes 
            => new byte[] { 0x0f, 0xc7, 0xf0, 0x0f, 0x92, 0x01, 0xc3};            


        /// <summary>
        /// The handle for the current process
        /// </summary>
        static readonly IntPtr ProcHandle = System.Diagnostics.Process.GetCurrentProcess().Handle;

        unsafe static IntPtr Liberate(this ReadOnlySpan<byte> src)
            => OS.Liberate(src);
   }
}