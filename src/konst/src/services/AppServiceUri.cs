//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AppServiceUri
    {
        public PartId DefiningPart {get;}

        public string HostName {get;}

        public string UriText {get;}

        [MethodImpl(Inline)]
        internal AppServiceUri(string name)
        {
            DefiningPart = PartId.None;
            HostName = EmptyString;
            UriText = EmptyString;
        }

        [MethodImpl(Inline)]
        public AppServiceUri(PartId owner, string name)
        {
            DefiningPart = owner;
            HostName = insist(name);
            UriText = owner != 0 ? text.format("{0}{1}{2}", DefiningPart.Format(), Chars.FSlash, HostName) : HostName;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(HostName);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(HostName);
        }

        [MethodImpl(Inline)]
        public static bool operator==(AppServiceUri a, AppServiceUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AppServiceUri a, AppServiceUri b)
            => !a.Equals(b);


        [MethodImpl(Inline)]
        public string Format()
            => UriText ?? EmptyString;

        [MethodImpl(Inline)]
        public bool Equals(AppServiceUri src)
            => string.Equals(UriText, src.UriText, NoCase);

        [MethodImpl(Inline)]
        public int CompareTo(AppServiceUri src)
            => UriText?.CompareTo(src.UriText) ?? int.MaxValue;

        public override int GetHashCode()
            => (int)hash(UriText);

        public override bool Equals(object src)
            => src is AppServiceUri x && Equals(x);

        public override string ToString()
            => Format();

        public static AppServiceUri Empty
            => new AppServiceUri(EmptyString);
    }
}