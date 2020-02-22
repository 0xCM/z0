//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    [ApiHost(ApiHostKind.Direct)]
    readonly struct BitConverters : 
        IUnmanagedConveter<bool,bit>, 
        IUnmanagedConveter<char,bit>, 
        IUnmanagedConveter<byte,bit>, 
        IUnmanagedConveter<ushort,bit>, 
        IUnmanagedConveter<uint,bit>, 
        IUnmanagedConveter<ulong,bit>,
        IUnmanagedConveter<bit,bool>, 
        IUnmanagedConveter<bit,char>, 
        IUnmanagedConveter<bit, byte>, 
        IUnmanagedConveter<bit, ushort>,  
        IUnmanagedConveter<bit, uint>, 
        IUnmanagedConveter<bit, ulong>         
    {
        [MethodImpl(Inline), Op]
        public bit Convert(bool src)
            => src;

        [MethodImpl(Inline), Op]
        public bit Convert(byte src)
            => (bit)src;

        [MethodImpl(Inline), Op]
        public bit Convert(ushort src)
            => (bit)src;

        [MethodImpl(Inline), Op]
        public bit Convert(uint src)
            => (bit)src;

        [MethodImpl(Inline), Op]
        public bit Convert(ulong src)
            => (bit)src;

        [MethodImpl(Inline), Op]
        public bit Convert(char src)
            => bit.Parse(src);

        [MethodImpl(Inline)]
        char IConverter<bit, char>.Convert(bit src)
            => src ? bit.One : bit.Zero;

        [MethodImpl(Inline)]
        bool IConverter<bit, bool>.Convert(bit src)
            => src;

        [MethodImpl(Inline)]
        byte IConverter<bit, byte>.Convert(bit src)
            => (byte)src;

        [MethodImpl(Inline)]
        ushort IConverter<bit, ushort>.Convert(bit src)
            => (ushort)src;

        [MethodImpl(Inline)]
        uint IConverter<bit, uint>.Convert(bit src)
            => (uint)src;

        [MethodImpl(Inline)]
        ulong IConverter<bit, ulong>.Convert(bit src)
            => (ulong)src;
    }
}