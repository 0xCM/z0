
       // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static ref T store<T>(in BitfieldSectionSpec seg, in T src, ref T dst)
        //     where T : unmanaged
        //         => ref gbits.bitcopy(src, (byte)seg.FirstIndex, (byte)seg.Width, ref dst);


        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static void store<T>(in BitfieldSectionSpecs spec, T src, Span<T> dst)
        //     where T : unmanaged
        // {
        //     var count = spec.FieldCount;
        //     for(var i=0u; i<count; i++)
        //         seek(dst,i) = read(skip(spec.Segments,i), src);
        // }

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static ref T store<T>(in BitfieldSectionSpecs spec, ReadOnlySpan<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     var count = spec.FieldCount;
        //     for(var i=0u; i<count; i++)
        //         store<T>(skip(spec.Segments,i), skip(src,i), ref dst);
        //     return ref dst;
        // }

        // [MethodImpl(Inline)]
        // public static void store<E,W,T>(in BitfieldSpec<E,W> spec, T src, Span<T> dst)
        //     where E : unmanaged, Enum
        //     where W : unmanaged, Enum
        //     where T : unmanaged
        // {
        //     var len = spec.Segments.Length;
        //     for(var i=0u; i<len; i++)
        //         seek(dst,i) = read(skip(spec.Segments,i), src);
        // }

        // [MethodImpl(Inline)]
        // public static void store<S,T>(in BitfieldSectionSpecs spec, in S src, Span<T> dst)
        //     where S : unmanaged
        //     where T : unmanaged
        // {
        //     for(var i=0u; i<spec.FieldCount; i++)
        //         seek(dst,i) = read<S,T>(skip(spec.Segments,i), src);
        // }

        // [MethodImpl(Inline)]
        // public static ref T store<S,T>(in BitfieldSectionSpec segment, in S src, ref T dst)
        //     where S : unmanaged
        //     where T : unmanaged
        //         => ref gbits.bitcopy(@as<S,T>(src), (byte)segment.FirstIndex, (byte)segment.Width, ref dst);

        // [MethodImpl(Inline)]
        // public static ref S store<S,T>(in BitfieldSectionSpec segment, in S src, ref S dst)
        //     where S : unmanaged
        //     where T : unmanaged
        // {
        //     var dstData = dst;
        //     gbits.bitcopy(src, (byte)segment.FirstIndex, (byte)segment.Width, ref dstData);
        //     return ref dst;
        // }

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static ref T store2<T>(in BitfieldSectionSpecs spec, ReadOnlySpan<T> src, ref T data)
        //     where T : unmanaged
        // {
        //     for(var i=0; i<spec.FieldCount; i++)
        //     {
        //         ref readonly var segment = ref skip(spec.Segments,i);
        //         gbits.bitcopy(skip(src,i), (byte)segment.FirstIndex, (byte)segment.Width, ref data);
        //     }
        //     return ref data;
        // }

        // public static BlockedBits<E,T,W> blocked<E,T,W>(uint bitcount)
        //     where E : unmanaged, Enum
        //     where T : unmanaged
        //     where W : unmanaged, Enum
        // {
        //     var data = blocked<T>(bitcount);
        //     var spec = new BitfieldSpec<E,W>(BitfieldSpecs.sections<E,T,W>(), bitcount);
        //     return new BlockedBits<E,T,W>(data, spec);
        // }

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static BitfieldSegment<T> segment<T>(BitfieldSectionSpec part, T state = default)
        //     where T : unmanaged
        //         => new BitfieldSegment<T>(part, state);

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static BitfieldSegment<T> segment<T>(Identifier name, byte i0, byte i1, T state = default)
        //     where T : unmanaged
        //         => new BitfieldSegment<T>(BitfieldSpecs.part(name, i0, i1), state);

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static T read<T>(in BitfieldSectionSpec seg, T src)
        //     where T : unmanaged
        //         => gbits.bitslice(src, (byte)seg.FirstIndex, (byte)seg.Width);

        // [MethodImpl(Inline)]
        // public static T read<S,T>(in BitfieldSectionSpec segment, in S src)
        //     where S : unmanaged
        //     where T : unmanaged
        //         => @as<S,T>(gbits.bitslice(src, (byte)segment.FirstIndex, (byte)segment.Width));

        // [MethodImpl(Inline)]
        // public static T read<S,T>(in BitfieldSectionSpec segment, in S src, bool offset)
        //     where S : unmanaged
        //     where T : unmanaged
        //         => offset ? gmath.sll(read<S,T>(segment, src), (byte)segment.FirstIndex) : read<S,T>(segment,src);

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static T offset<T>(in BitfieldSectionSpec seg, T src)
        //     where T : unmanaged
        //         => gmath.sll(read(seg, src), (byte)seg.FirstIndex);

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static BitfieldCover<T> create<T>(in BitfieldSectionSpecs spec, T state = default)
        //     where T : unmanaged
        //         => new BitfieldCover<T>(spec, state);

        // [MethodImpl(Inline)]
        // public static BitfieldCover<S,E,T> create<S,E,T>(in BitfieldSectionSpecs spec, T state = default)
        //     where S : unmanaged
        //     where E : unmanaged, Enum
        //     where T : unmanaged
        //         => new BitfieldCover<S,E,T>(spec, state);

        // [MethodImpl(Inline)]
        // public static BitfieldCover<S,E,T> create<S,E,T,W>(T state = default)
        //     where S : unmanaged
        //     where E : unmanaged, Enum
        //     where W : unmanaged, Enum
        //     where T : unmanaged
        //         => new BitfieldCover<S,E,T>(BitfieldSpecs.sections<E,T,W>(), state);

        // public static string format<T>(in BitfieldCover<T> src)
        //     where T : unmanaged
        // {
        //     var dst = text.buffer();
        //     render(src,dst);
        //     return dst.Emit();
        // }

        // [Op, Closures(UInt64k)]
        // public static void render<T>(in BitfieldCover<T> src, ITextBuffer dst)
        //     where T : unmanaged
        // {
        //     var count = src.Spec.FieldCount;
        //     var last = count - 1;
        //     dst.Append(Chars.LBracket);

        //     for(var i=last; i>=0; i--)
        //     {
        //         ref readonly var seg = ref src.Segment((byte)i);
        //         dst.AppendFormat("{0}:{1}", seg.Name, bit.format(src.Extract((byte)i), seg.Width));

        //         if(i != 0)
        //             dst.Append(RP.SpacedPipe);

        //     }
        //     dst.Append(Chars.RBracket);
        // }

        // [Op]
        // public static BitFieldModel model(Name name, ReadOnlySpan<string> names, ReadOnlySpan<byte> widths)
        // {
        //     var count = (uint)names.Length;
        //     var fieldWidths = span(widths);
        //     var posbuffer = alloc<uint>(count);
        //     var positions = span(posbuffer);
        //     var sBuffer = alloc<BitfieldSectionSpec>(count);
        //     var segments = span(sBuffer);
        //     uint totalWidth = 0;
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var w = ref skip(widths,i);
        //         ref readonly var segname = ref skip(names,i);
        //         seek(positions,i) = totalWidth;
        //         seek(segments,i) = part(segname, (byte)totalWidth, (byte)(totalWidth + w));
        //         totalWidth += skip(fieldWidths, i);
        //     }
        //     return new BitFieldModel(name, count, totalWidth, sBuffer);
        // }

        // [Op]
        // public static void render(in BitfieldSectionSpec src, ITextBuffer dst)
        //     => dst.Append(src.Format());

        // public static string format<T>(BitfieldSectionSpec<T> src)
        //     where T : unmanaged
        //         => text.enclose(text.adjacent(src.LastIndex, SegmentDelimiter, src.FirstIndex), SegmentFence);

        // [Op]
        // static string[] lines(in BitFieldModel src)
        // {
        //     var dst = new string[src.SectionCount];
        //     for(var i=0; i<src.SectionCount; i++)
        //     {
        //         var index = i;
        //         var indexLabel = index.ToString().PadLeft(2, Chars.D0);
        //         var width = src.Width(i);
        //         var widthLabel = width.ToString().PadLeft(2, Chars.D0);
        //         var left = src.Position(i);
        //         var leftLabel = left.ToString().PadLeft(2, Chars.D0);
        //         var right = left + width - 1;
        //         var rightLabel = right.ToString().PadLeft(2, Chars.D0);
        //         dst[i] = $"{index} | {indexLabel} | {widthLabel} | [{leftLabel}..{rightLabel}]";
        //     }
        //     return dst;
        // }

        // [Op]
        // public static string format(in BitFieldModel src)
        //     => lines(src).Intersperse(Eol).Concat();

        // public static string format<F>(IBitFieldIndexEntry<F> entry)
        //     where F : unmanaged
        //         => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";

        // public static string format<W>(BitFieldIndexEntry<W> src)
        //     where W : unmanaged, Enum
        //         => $"{src.FieldWidth.GetType().Name}[{src.FieldIndex}] = {src.FieldName}";

        // public static string format<T>(ReadOnlySpan<BitfieldSectionSpec<T>> src)
        //     where T : unmanaged
        // {
        //     var dst = text.buffer();
        //     dst.Append(OpenField);
        //     var count = src.Length;
        //     var last = count - 1;
        //     for(var i=last; i>=0; i--)
        //     {
        //         render(skip(src,i), dst);
        //         if(i != 0)
        //             dst.Append(SegSep);
        //     }

        //     dst.Append(CloseField);
        //     return dst.Emit();
        // }

        // [Op]
        // public static string format(ReadOnlySpan<BitfieldSectionSpec> src)
        // {
        //     var dst = text.buffer();
        //     dst.Append(OpenField);
        //     var count = src.Length;
        //     var last = count - 1;
        //     for(var i=last; i>=0; i--)
        //     {
        //         render(skip(src,i), dst);
        //         if(i != 0)
        //             dst.Append(SegSep);
        //     }

        //     dst.Append(CloseField);
        //     return dst.Emit();
        // }

        // [Op]
        // public static string format(in BitfieldSectionSpec seg)
        // {
        //     var dst = EmptyString;
        //     var name = seg.Name;
        //     if(name.IsNonEmpty)
        //         dst = seg.Name;
        //     return dst + string.Format(SegPattern, seg.FirstIndex, seg.LastIndex);
        // }

        // const string SegPattern = "[{1}:{0}]";

        // const string SegSep = RP.SpacedPipe;

        // const char OpenField = Chars.LBracket;

        // const char CloseField = Chars.RBracket;

        //public const char SegmentDelimiter = Chars.Colon;

        // public static Fence<char> SegmentFence
        // {
        //     [MethodImpl(Inline)]
        //     get => Rules.fence(OpenField, CloseField);
        // }
