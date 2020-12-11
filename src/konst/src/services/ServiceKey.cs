//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    /// <summary>
    /// Identifies a service reification
    /// </summary>
    public readonly struct ServiceKey
    {
        readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public ServiceKey(uint host, uint contract)
            => Data = vparts(w128, host, contract, 0u, 0u);

        [MethodImpl(Inline)]
        public ServiceKey(uint host, uint contract, uint kind, uint tKind)
            => Data = vparts(w128, host, contract, kind, tKind);

        public uint Host
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }

        public uint Contract
        {
            [MethodImpl(Inline)]
            get => vcell(Data,1);
        }

        public uint KindValue
        {
            [MethodImpl(Inline)]
            get => vcell(Data,2);
        }

        public uint KindType
        {
            [MethodImpl(Inline)]
            get => vcell(Data,3);
        }

        public bool IsKinded
        {
            [MethodImpl(Inline)]
            get =>KindValue != 0 && KindType != 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host == 0 && Contract == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Host != 0 && Contract != 0;
        }

        public string Format(ServiceKey src)
            => IsKinded
            ? string.Format("{0}->{1}[{2}:{3}]")
            : string.Format("{0}->{1}", Host, Contract);

        public ParseResult<ServiceKey> Parse(string src)
        {
            var fail = unparsed<ServiceKey>(src);
            var length = text.length(src);
            if(length != 0)
            {
                var a = text.split(src,"->");
                if(a.Length==2)
                {
                    var host = a[0];
                    var rest = a[1];
                    var b = text.split(src, Chars.LBracket);
                }

            }
            return fail;
        }
    }
}