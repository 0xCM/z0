//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a data structure representing a name that has size IMAGE_SIZEOF_SHORT_NAME as specified
    /// by https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-image_section_header
    /// </summary>
    public unsafe readonly struct ShortName
    {
        readonly byte[] Data;
        
        [MethodImpl(Inline)]
        public ShortName(byte[] src)
            => Data = src;

        public string Text
        {
            [MethodImpl(Inline)]
            get
            {
                fixed (byte* ptr = Data)
                {
                    if (ptr[7] == 0)
                        return Marshal.PtrToStringAnsi((IntPtr)ptr);
                    else
                        return Marshal.PtrToStringAnsi((IntPtr)ptr, 8);
                }
            }
        }
    }            
}