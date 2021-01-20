//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct HexStrings<K>
        where K : unmanaged
    {
        public readonly StringRef[] Refs;

        [MethodImpl(Inline)]
        public HexStrings(params StringRef[] src)
            => Refs = src;

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Chars(uint index)
        {
            ref var src = ref Refs[index];
            return cover(src.BaseAddress.Pointer<char>(), (uint)src.Length);
        }

        [MethodImpl(Inline)]
        public unsafe string String(uint index)
           => Refs[index].Text;

        public unsafe string this[uint index]
        {
            [MethodImpl(Inline)]
            get => String(index);
        }

        public static HexStrings<K> Empty
            => new HexStrings<K>(StringRef.Empty);
    }
}