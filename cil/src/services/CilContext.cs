//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;    

    using static Core;

    readonly struct CilContext : ICilContext
    {
        [MethodImpl(Inline)]
        public static ICilContext Define(IContext root)
            => new CilContext(root);

        [MethodImpl(Inline)]
        CilContext(IContext root)
        {
            this.CilFormat = CilFormatConfig.Default;
        }

        public CilFormatConfig CilFormat {get;}
    }
}