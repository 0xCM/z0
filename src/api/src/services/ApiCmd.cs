//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using K = ApiCmd;

    public enum ApiCmd : byte
    {
        None = 0,

        EmitAssetContent,
    }

    sealed class ApiCmdHost : AppCmdHost<ApiCmdHost,K>
    {
        Lazy<ApiAssets> _ApiAssets;

        ApiAssets ApiAssets
        {
            [MethodImpl(Inline)]
            get => _ApiAssets.Value;
        }

        protected override void OnInit()
        {
            _ApiAssets = root.lazy(Wf.ApiAssets);
        }

        [Action(K.EmitAssetContent)]
        void EmitResourceContent()
            => ApiAssets.EmitAssetContent();
    }
}