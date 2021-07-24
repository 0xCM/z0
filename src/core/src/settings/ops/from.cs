//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static core;

    partial struct Settings
    {
        public static Settings from<T>(T src)
        {
            var _fields = typeof(T).PublicInstanceFields();
            var _props = typeof(T).PublicInstanceProperties();
            var _fieldValues = from f in _fields
                                let value = f.GetValue(src)
                                where f != null
                                select new Setting(f.Name, value);

            var _propValues = from f in _props
                                let value = f.GetValue(src)
                                where f != null
                                select new Setting(f.Name, value);

            return _fieldValues.Union(_propValues).Array();
        }
    }
}