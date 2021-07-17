//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using static Root;

    public class PartNames
    {
        public static IReadOnlyDictionary<PartId,PartName> lookup()
            => _Instance._Lookup;

        static PartNames _Instance;

        Dictionary<PartId,PartName> _Lookup;

        static Dictionary<PartId,PartName> names()
        {
            var fields = typeof(PartId).LiteralFields().ToReadOnlySpan();
            var dst = new Dictionary<PartId,PartName>();
            foreach(var f in fields)
            {
                var key = (PartId)f.GetRawConstantValue();
                var name = f.Tag<SymbolAttribute>().MapValueOrElse(a => a.Symbol, () => f.Name);
                var pn = new PartName(key,name);
                dst.TryAdd(key,pn);
            }
            return dst;
        }

        static PartNames()
        {
            _Instance = new PartNames(names());
        }

        PartNames(Dictionary<PartId,PartName> src)
        {
            _Lookup = src;
        }
    }
}