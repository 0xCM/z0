//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct XedSettings : ISettings<XedSettings>
    {
        [MethodImpl(Inline)]
        public static XedSettings Default()
        {
            var settings = new XedSettings();
            settings.EmitSummary = true;
            settings.EmitRules = true;
            settings.EmitMnemonicList = true;
            settings.EmitExtensions = true;
            settings.EmitCategories = true;
            return settings;
        }

        public bool EmitSummary;

        public bool EmitCategories;

        public bool EmitMnemonicList;

        public bool EmitExtensions;

        public bool EmitRules;
    }
}