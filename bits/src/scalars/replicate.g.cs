//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                        
        [MethodImpl(Inline)]
        public static T replicate<T>(N64 mod, T src, int? from = null, int? to = null, int? reps = null)
            where T : unmanaged
        {
            var i0 = from ?? 0;
            var i1 = to ?? msbpos(src);
            var width = i1 - i0 + 1;
            var count = reps ?? (natval(mod) / width +  1);
            return convert<T>(Bits.replicate(convert<T,ulong>(src), i0, i1, count));
        }

        [MethodImpl(Inline)]
        public static T replicate<T>(N32 mod, T src, int from, int to, int reps)
            where T : unmanaged
                => convert<T>(Bits.replicate(convert<T,uint>(src), from, to, reps));

        [MethodImpl(Inline)]
        public static T replicate<T>(N16 mod, T src, int from, int to, int reps)
            where T : unmanaged
                => convert<T>(Bits.replicate(convert<T,ushort>(src), from, to, reps));

        [MethodImpl(Inline)]
        public static T replicate<T>(N8 mod, T src, int from, int to, int reps)
            where T : unmanaged
                => convert<T>(Bits.replicate(convert<T,byte>(src), from, to, reps));

        [MethodImpl(Inline)]
        public static T replicate<T>(T src, int from, int to, int reps)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.replicate(uint8(src), from, to , reps));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.replicate(uint16(src), from, to , reps));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.replicate(uint32(src), from, to , reps));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.replicate(uint64(src), from, to , reps));
            else 
                throw unsupported<T>();
        }
    }

}