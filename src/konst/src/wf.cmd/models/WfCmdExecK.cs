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

    public readonly struct WfCmdExec<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public WfCmdExec Enclosed {get;}

        [MethodImpl(Inline)]
        public WfCmdExec(K kind, WfCmdExec cmd)
        {
            Kind = kind;
            Enclosed = cmd;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfCmdExec(WfCmdExec<K> src)
            => src.Enclosed;

        [MethodImpl(Inline)]
        public static implicit operator K(WfCmdExec<K> src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator WfCmdExec<K>((K kind, WfCmdExec cmd) src)
            => new WfCmdExec<K>(src.kind, src.cmd);
    }

}