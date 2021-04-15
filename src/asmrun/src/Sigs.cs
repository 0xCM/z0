//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    [ApiHost]
    public unsafe readonly struct Sigs
    {
        [MethodImpl(Inline), Op]
        public static delegate* unmanaged<int,int,int> func_32i_32i_32i(void* f)
            => (delegate* unmanaged<int,int,int>) f;

        [MethodImpl(Inline), Op]
        public static int invoke(delegate* unmanaged<int,int,int> f, int a, int b)
            => f(a,b);
    }

    [ApiHost]
    public readonly unsafe struct SigClient
    {
        static ReadOnlySpan<byte> Store4 => new byte[4]{0x8D, 0x04, 0x11, 0xc3}; // lea eax, [rcx+rdx] | ret

        [MethodImpl(Inline), Op]
        public static int run1(in CodeBuffers src)
        {
            var f0 = (delegate* unmanaged<int, int, int>)ptr(src.Buffer128);
            return Sigs.invoke(f0,42,378);
        }

        [MethodImpl(Inline), Op]
        public static int run2(in CodeBuffers src)
        {
            var f1 = Sigs.func_32i_32i_32i(ptr(src.Buffer128));
            return f1(42,378);
        }

        public static void run()
        {
            var buffers = CodeBuffers.create();
            ref readonly var input =  ref u32(first(Store4));

            var buffer = recover<uint>(buffers.Buffer128);
            seek(buffer,0) = input;

            Console.WriteLine(run1(buffers));
            Console.WriteLine(run2(buffers));
        }
    }
}