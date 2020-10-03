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

    using api = ApiIdentity;

    public readonly struct ApiHostUri : IApiUri<ApiHostUri>, INullary<ApiHostUri>
    {
        public readonly PartId Owner;

        public readonly string Name;

        public string UriText {get;}

        public FolderName HostFolder
            => FolderName.Define(Name);

        public FS.FileName FileName(FileExtension ext)
            => FS.file(text.concat(Owner.Format(), Chars.Dot, Name), ext);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Name);
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
        public ApiHostUri(PartId owner, string name)
        {
            Owner = owner;
            Name = insist(name);
            UriText = owner != 0 ? text.format("{0}{1}{2}", Owner.Format(), ApiUriDelimiters.UriPathSep, Name) : Name;
        }

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
            => (int)hash(UriText);

        public override bool Equals(object src)
            => src is ApiHostUri x && Equals(x);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        ApiHostUri(string name)
        {
            Owner = PartId.None;
            Name = EmptyString;
            UriText = EmptyString;
        }

        public static ApiHostUri Empty
            => new ApiHostUri(EmptyString);
    }
}