//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly partial struct Settings : IIndex<Setting>, ILookup<string,Setting>
    {
        const NumericKind Closure = UnsignedInts;

        readonly Index<Setting> Data;

        [MethodImpl(Inline)]
        public Settings(Setting[] src)
            => Data = src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> empty<T>()
            => Setting<T>.Empty;

        public ref Setting this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Setting this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            get => Data.Length;
        }

        public Setting[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<Setting> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Setting> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public bool Lookup(string key, out Setting value)
            => search(this,key,out value);

        public string Format()
            => format(Data);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Settings(Setting[] src)
            => new Settings(src);

        [MethodImpl(Inline)]
        public static implicit operator Setting[](Settings src)
            => src.Storage;

        [Op]
        public static uint save(in Settings src, StreamWriter dst)
        {
            var settings = src.View;
            var count = (uint)settings.Length;
            if(count == 0)
                return count;

            for(var i = 0; i<count; i++)
            {
                ref readonly var setting = ref skip(settings,i);
                dst.WriteLine(string.Format(RP.Setting, setting.Name, setting.Value));
            }
            return count;
        }

        [Op]
        public static bool search(in Settings src, string key, out Setting value)
        {
            var view = src.Data.View;
            var count = src.Data.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var setting = ref skip(view,i);
                if(string.Equals(setting.Name, key, NoCase))
                {
                    value = setting;
                    return true;
                }
            }
            value = Setting.Empty;
            return false;
        }

        [Op]
        public static Settings parse(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var buffer = alloc<Setting>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst, i) = parse(skip(src,i));
            return buffer;
        }

        public static Setting parse(string src)
        {
            var i = SQ.index(src, Chars.Colon);
            var setting = Setting.Empty;
            if(i > 0)
            {
                var name = SQ.left(src, i).Format().Trim();
                var value = SQ.right(src, i).Format().Trim();
                setting = new Setting(name, value);
            }
            return setting;
        }

        [Op]
        public static Settings parse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            var buffer = span<Setting>(count);
            ref var dst = ref first(buffer);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = SQ.index(content, Chars.Colon);
                if(j > 0)
                {
                    var name = SQ.left(content, j).Format().Trim();
                    var value = SQ.right(content, j).Format().Trim();
                    seek(dst, counter++) = new Setting(name, value);
                }
            }
            return slice(buffer,0,counter).ToArray();
        }

        public static Settings Empty => new Settings(sys.empty<Setting>());
    }
}