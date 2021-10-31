//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public static Settings Empty => new Settings(sys.empty<Setting>());
    }
}