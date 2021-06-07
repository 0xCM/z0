//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    public struct PartNames
    {
        public static PartNames create(ReadOnlySpan<Assembly> src)
            => new PartNames(src);

        KeyedValues<PartId,PartName> _PartNames;

        readonly PartId[] _Parts;

        public ReadOnlySpan<PartId> Parts
        {
            [MethodImpl(Inline), Op]
            get => _Parts;
        }

        public PartName this[PartId id]
        {
            [MethodImpl(Inline), Op]
            get => _PartNames[id];
        }

        PartNames(ReadOnlySpan<Assembly> src)
        {
            var names = list<PartName>();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var a = ref skip(src,i);
                var name = PartName.from(a);
                if(name.IsNonEmpty)
                    names.Add(name);
            }
            var count = names.Count;
            _Parts = alloc<PartId>(count);
            var kvpairs = alloc<KeyedValue<PartId,PartName>>(count);
            ref var kvpair = ref first(kvpairs);
            for(var i=0; i<count; i++)
            {
                var x = names[i];
                seek(kvpair,i) = kvp(x.Id,x);
                _Parts[i] = x.Id;
            }
            _PartNames = kvpairs;
        }
    }
}