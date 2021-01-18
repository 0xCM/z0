//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static System.Runtime.InteropServices.Marshal;
    using static Part;
    using static memory;

    [ApiHost(ApiNames.MemoryModels, true)]
    public readonly struct MemoryModels
    {
        public static void update<E,T>(ReadOnlySpan<BinaryCode> src, MemorySlots<E> slots, T dst)
            where E : unmanaged, Enum
        {
            var count = slots.Length;
            ref readonly var lead = ref slots.Lookup(default(E));
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                ref readonly var source = ref code[0];
                ref readonly var slot = ref skip(lead, i);
                ref var target = ref slot.BaseAddress.Ref<byte>();
                for(var j=0u; j<slot.Length; j++)
                    seek(target,j) = skip(source,j);
            }
        }

        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(FieldInfo src)
            => (Address64)OffsetOf(src.DeclaringType, src.Name);

        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(Type t, StringRef name)
            => Option.Try(() => (Address64)OffsetOf(t, name)).ValueOrDefault();

        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(Type t, string name)
            => Option.Try(() => (Address64)OffsetOf(t, name)).ValueOrDefault();

        /// <summary>
        /// Invokes <see cref='OffsetOf{T}'/>
        /// </summary>
        /// <param name="src">the source field name</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Address64 offset<T>(string field)
            => Option.Try(() => (Address64)OffsetOf<T>(field)).ValueOrDefault();

        [MethodImpl(Inline), Op]
        public static int compare(in MemoryOffset a, in MemoryOffset b)
            => a.Base == b.Base ? (a.Offset.CompareTo(b.Offset)) : a.Base.CompareTo(b.Base);

        [MethodImpl(Inline), Op]
        public static bool equals(in MemoryOffset a, in MemoryOffset b)
            => a.Base == b.Base && a.Offset == b.Offset;

        [MethodImpl(Inline), Op]
        public static int hash(in MemoryOffset src)
            => (int)alg.hash.calc((ulong)src.Base, (ulong)src.Offset);

        [Op]
        public static string format(in MemoryOffset src, char delimiter)
        {
            MemoryAddress offset = src.Offset;
            return string.Concat(src.Base.Format(), delimiter, offset.Format(src.OffsetWidth));
        }

        [MethodImpl(Inline), Op]
        public static MemoryOffset accrue(in MemoryOffset src, ulong dx)
            => new MemoryOffset(src.Base, src.Offset + dx, src.OffsetWidth);

        [MethodImpl(Inline), Op]
        public static string format(in MemoryOffset moffs)
            => text.concat(((ushort)moffs.Offset).FormatAsmHex(), Chars.Space, moffs.Absolute);

        [Op]
        public static Span<string> format(in MemoryOffsets offsets)
        {
            var empty = MemoryOffset.Empty;
            var dst = memory.alloc<string>(offsets.Count);
            format(offsets,dst);
            return dst;
        }

        [Op]
        public static void format(in MemoryOffsets offsets, Span<string> dst)
        {
            var empty = MemoryOffset.Empty;
            for(var k=0u; k<offsets.Count; k++)
            {
                ref readonly var prior = ref (k == 0 ? ref empty : ref offsets[k-1]);
                ref readonly var current = ref offsets[k];
                seek(dst,k) = format(prior, current);
            }
        }

        [Op]
        public static string format(in MemoryOffset prior, in MemoryOffset moffs)
        {
            const char Sep = Chars.Space;
            const NumericWidth OffsetWidth = NumericWidth.W16;
            const string BaseIndicator = "@base";
            const string PriorIndicator = "@prior";
            const char Selector = Chars.Plus;

            var offset = moffs.OffsetAddress;
            var offsetFmt = offset.Format(OffsetWidth);
            var moffsBase = text.concat(BaseIndicator, Selector, offsetFmt);
            var priorFmt = text.concat(PriorIndicator, Selector, prior.Absolute.Format(OffsetWidth));

            if(prior.IsEmpty)
                return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, priorFmt);

            var delta = moffs.Absolute - prior.Absolute;
            var deltaFmt = delta.Format(OffsetWidth);
            var moffsPrior = text.concat(PriorIndicator, Selector, deltaFmt);

            return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, moffsPrior);
        }

        [MethodImpl(Inline)]
        public static RelativeAddress<BW,RW,B,R> address<BW,RW,B,R>(B @base, R offset, BW bw = default, RW rw = default)
            where BW: unmanaged, INumericWidth
            where RW: unmanaged, INumericWidth
            where B: unmanaged
            where R: unmanaged
                => new RelativeAddress<BW,RW,B,R>(@base, offset);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W32,W16,uint,ushort> address(uint @base, ushort offset)
            => address(@base, offset, w32, w16);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W8,ulong,byte> address(ulong @base, byte offset)
            => address(@base, offset, w64, w8);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W16,ulong,ushort> address(ulong @base, ushort offset)
            => address(@base, offset, w64, w16);

        [MethodImpl(Inline), Op]
        public static Address<W8,byte> address(W8 w, byte src)
            => new Address<W8,byte>(src);

        [MethodImpl(Inline), Op]
        public static Address<W16,ushort> address(W16 w, ushort src)
            => new Address<W16,ushort>(src);

        [MethodImpl(Inline), Op]
        public static Address<W32,uint> address(W32 w, uint src)
            => new Address<W32,uint>(src);

        [MethodImpl(Inline), Op]
        public static Address<W64,ulong> address(W64 w, ulong src)
            => new Address<W64,ulong>(src);
    }
}