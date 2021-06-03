//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiHostUri : IApiUri<ApiHostUri>, INullary<ApiHostUri>
    {
        public PartId Part {get;}

        public string Name {get;}

        public string UriText {get;}

        [MethodImpl(Inline)]
        public ApiHostUri(PartId owner, string name)
        {
            Part = owner;
            //Name = core.require(name != null, name, () => "Null names are bad");
            Name = name ?? "__empty__";
            UriText = owner != 0 ? string.Format("{0}{1}{2}", Part.Format(), ApiUriDelimiters.UriPathSep, Name) : Name;
        }

        public Name Id
            => IsEmpty ? "__empty__" : string.Format("{0}.{1}", Part.Format(), Name);

        [MethodImpl(Inline)]
        ApiHostUri(string name)
        {
            Part = PartId.None;
            Name = EmptyString;
            UriText = EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => minicore.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => minicore.nonempty(Name);
        }

        ApiHostUri INullary<ApiHostUri>.Zero
            => Empty;

        [MethodImpl(Inline)]
        public static bool operator==(ApiHostUri a, ApiHostUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHostUri a, ApiHostUri b)
            => !a.Equals(b);


        [MethodImpl(Inline)]
        public string Format()
            => UriText ?? EmptyString;

        [MethodImpl(Inline)]
        public bool Equals(ApiHostUri src)
            => string.Equals(UriText, src.UriText, NoCase);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHostUri src)
            => UriText?.CompareTo(src.UriText) ?? int.MaxValue;

        public override int GetHashCode()
            => (int)UriText.GetHashCode();

        public override bool Equals(object src)
            => src is ApiHostUri x && Equals(x);

        public override string ToString()
            => Format();

        public static ApiHostUri Empty
            => new ApiHostUri(EmptyString);
    }
}