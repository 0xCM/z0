//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct XedSettings
    {
        [MethodImpl(Inline)]
        public static XedSettings Default()
        {
            var settings = new XedSettings();
            settings.EmitSummary = true;
            settings.EmitRules = true;
            return settings;
        }

        public bool EmitSummary;

        public bool EmitCatagories;

        public bool EmitMnemonicList;

        public bool EmitExtensions;

        public bool EmitRules;
    }
}