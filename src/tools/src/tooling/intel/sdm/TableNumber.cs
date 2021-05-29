//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        public readonly struct TableNumber
        {
            const string Marker = "Table ";

            const char Delimiter = Chars.Dash;

            public byte Major {get;}

            public byte Minor {get;}

            [MethodImpl(Inline)]
            public TableNumber(byte major, byte minor)
            {
                Major = major;
                Minor = minor;
            }

            public override string ToString()
                => string.Format("{0} {1}-{2}", Marker, Major, Minor);

            public static Outcome parse(string src, out TableNumber dst)
            {
                dst = default;
                var i = src.IndexOf(Marker);
                if(i == NotFound)
                    return (false, string.Format("Marker '{0}' not present", Marker));
                src = src.RightOfFirst(Marker);
                var parts = src.Split(Delimiter);
                if(parts.Length < 2)
                    return (false, string.Format("Delimiter '{0}' not present", Delimiter));

                var a0 = first(parts);
                var result = DataParser.parse(a0, out byte major);
                if(result.Fail)
                    return (false, string.Format("Unable to parse major attribute from {0}", a0));

                var a1 = @span(skip(parts,1));
                var tmp = EmptyString;
                for(var j=0; j<a1.Length; j++)
                {
                    ref readonly var c = ref skip(a1,j);
                    if(!Char.IsDigit(c))
                        break;
                    tmp += c;
                }
                result = DataParser.parse(tmp, out byte minor);
                if(result.Fail)
                    return (false, string.Format("Unable to parse minor attribute from {0}", a1.ToString()));
                dst = new (major,minor);
                return true;
            }
        }
    }
}