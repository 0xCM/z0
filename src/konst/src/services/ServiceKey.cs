//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Identifies a service reification
    /// </summary>
    public readonly struct ServiceKey
    {
        public uint Host {get;}

        public uint Contract {get;}

        public uint KindValue {get;}

        public uint KindType {get;}

        [MethodImpl(Inline)]
        public ServiceKey(uint host, uint contract)
        {
            Host = host;
            Contract = contract;
            KindValue = 0;
            KindType = 0;
        }

        [MethodImpl(Inline)]
        public ServiceKey(uint host, uint contract, uint kind, uint tKind)
        {
            Host = host;
            Contract = contract;
            KindValue = kind;
            KindType = tKind;
        }

        public bool IsKinded
        {
            [MethodImpl(Inline)]
            get => KindValue != 0 && KindType != 0;
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

        public ParseResult<ServiceKey> Parse(string src)
        {
            var fail = root.unparsed<ServiceKey>(src);
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