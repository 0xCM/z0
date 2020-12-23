//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct StringTable
    {
        [Op, Closures(UnsignedInts)]
        internal static StringTable<T> define<T>(MemoryAddress @base, T[] offsets, T[] lengths)
            => new StringTable<T>(@base, offsets, lengths);

        public static StringTable<T> alloc<T>(MemoryAddress @base, uint count)
            => new StringTable<T>(@base, sys.alloc<T>(count), sys.alloc<T>(count));

    }

    public readonly struct StringTable<T>
    {
        public MemoryAddress BaseAddress {get;}

        readonly T[] Offsets;

        readonly T[] Lengths;

        internal StringTable(MemoryAddress @base, T[] offsets, T[] lengths)
        {
            BaseAddress = @base;
            Offsets = offsets;
            Lengths = lengths;
        }

        public void Assign(uint index, T offset, T length)
        {
            seek(Offsets,index) = offset;
            seek(Lengths,index) = length;
        }

        public ReadOnlySpan<char> this[uint index]
        {
            [MethodImpl(Inline)]
            get => Lookup(index);
        }

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Lookup(uint index)
        {
            var @base = BaseAddress + NumericCast.force<ulong>(skip(Offsets, index));
            var length = NumericCast.force<uint>(skip(Lengths, index));
            return cover(@base.Pointer<char>(), length);
        }
    }


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