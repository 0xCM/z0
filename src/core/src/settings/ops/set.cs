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

    partial struct Settings
    {
        public static Index<Setting> set<T>(T src)
            where T : ISettingsSet<T>, new()
        {
            var _fields = typeof(T).PublicInstanceFields().Reify<ISetting>();
            var _props = typeof(T).PublicInstanceProperties().Reify<ISetting>();

            var _fieldValues = from f in _fields
                                let value = f.GetValue(src) as ISetting
                                where f != null
                                let name = minicore.ifempty(value.Name, f.Name)
                                select new Setting(name, value);

            var _propValues = from f in _props
                                let value = f.GetValue(src) as ISetting
                                where f != null
                                let name = minicore.ifempty(value.Name, f.Name)
                                select new Setting(name, value);

            return _fieldValues.Union(_propValues).Array();
        }
    }
}