//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Sequential<T> next<T>(in Sequential<T> src)
            where T : unmanaged
        {
            ref var dst = ref @edit(src);
            ref var value = ref dst.Value;

            if(size<T>() == 1)
                uint8(ref value) = (byte)(uint8(value) + 1);
            else if(size<T>() == 2)
                uint16(ref value) = (ushort)(uint16(value) + 1);
            else if(size<T>() == 4)
                uint32(ref value) = uint32(value) + 1u;
            else if(size<T>() == 8)
                uint64(ref value) = uint64(value) + 1ul;
            else
                throw no<T>();

            return ref dst;
        }

        /// <summary>
        ///  Effects: movzx eax,byte ptr [rcx] => mov [rdx],al => eax,byte ptr [rdx+1] => mov [rdx],al => rax,[rcx+1]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in byte src, ref byte dst)
            => ref gNext(src, ref dst);

        /// <summary>
        /// Effects: movzx eax,word ptr [rcx] => mov [rdx],ax => movzx eax,word ptr [rdx+2] => [rdx],ax => lea rax,[rcx+2]
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in byte src, ref ushort dst)
            => ref gNext(src, ref dst);

        /// <summary>
        /// Effects: mov eax,[rcx] => mov [rdx],eax => mov eax,[rdx+4] => mov [rdx],eax => lea rax,[rcx+4]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in byte src, ref uint dst)
            => ref gNext(src, ref dst);

        /// <summary>
        /// Effects: mov rax,[rcx] => mov [rdx],rax => mov rax,[rdx+8] => mov [rdx],rax => lea rax,[rcx+8]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in byte src, ref ulong dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in sbyte src, ref byte dst)
            => ref @as<byte>(gNext(src, ref dst));

        /// <summary>
        ///
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in sbyte src, ref ushort dst)
            => ref @as<byte>(gNext(src, ref dst));

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in sbyte src, ref uint dst)
            => ref @as<byte>(gNext(src, ref dst));

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte next(in sbyte src, ref ulong dst)
            => ref @as<byte>(gNext(src, ref dst));

        /// <summary>
        /// movzx eax,byte ptr [rcx] => mov [rdx],al => movzx eax,byte ptr [rdx+1] => mov [rdx],al => lea rax,[rcx+2]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort next(in ushort src, ref byte dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort next(in ushort src, ref ushort dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort next(in ushort src, ref uint dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ushort next(in ushort src, ref ulong dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint next(in uint src, ref byte dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint next(in uint src, ref ushort dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint next(in uint src, ref uint dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint next(in uint src, ref ulong dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ulong next(in ulong src, ref byte dst)
            => ref gNext(src, ref dst);

        /// <summary>
        ///
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ulong next(in ulong src, ref ushort dst)
            => ref gNext(src, ref dst);

        /// <summary>
        /// mov eax,[rcx] => mov [rdx],eax => mov eax,[rdx+4] => mov [rdx],eax => lea rax,[rcx+20h]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ulong next(in ulong src, ref uint dst)
            => ref gNext(src, ref dst);

        /// <summary>
        /// mov rax,[rcx] => mov [rdx],rax => mov rax,[rdx+8] => [rdx],rax => lea rax,[rcx+40h]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref ulong next(in ulong src, ref ulong dst)
            => ref gNext(src, ref dst);

        [MethodImpl(Inline)]
        static ref  S gNext<S,T>(in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = @as<S,T>(src);
            dst = add(dst, 1);
            return ref add(src, size<T>());
        }
    }
}