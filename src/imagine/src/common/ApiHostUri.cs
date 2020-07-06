//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static IdentityShare;


    public readonly struct ApiHostUri : IUri<ApiHostUri>, INullary<ApiHostUri>
    {        
        public static FileName HostFileName(PartId owner, string hostname, FileExtension ext)
            => Z0.FileName.Define(text.concat(owner.Format(), Chars.Dot, hostname), ext);

        public readonly PartId Owner;

        public readonly string Name;        

        public string UriText {get;}

        public FolderName HostFolder 
            => FolderName.Define(Name);

        public FileName FileName(FileExtension ext)
            => Z0.FileName.Define(text.concat(Owner.Format(), Chars.Dot, Name), ext);
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Owner == 0  && text.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Owner != 0 && !text.empty(Name);
        }

        ApiHostUri INullary<ApiHostUri>.Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public static ParseResult<ApiHostUri> Parse(string src)
        {
            var parts = src.Split(UriDelimiters.PathSep);
            if(parts.Length == 2 && Enum.TryParse(parts[0], true, out PartId owner))
            {
                var host = parts[1];
                if(!text.empty(host))
                    return ParseResult.Success(src, Define(owner, host));
            }
            
            return ParseResult.Fail<ApiHostUri>(src);
        }

        [MethodImpl(Inline)]
        public static ApiHostUri FromHost(Type host)
        {
            var tag = host.Tag<ApiHostAttribute>();
            var name = Root.ifempty(tag.MapValueOrDefault(x => x.HostName), host.Name);
            var owner = host.Assembly.Id();
            return new ApiHostUri(owner, name);
        }

        public static ParseResult<ApiHostUri> Parse(FileName src)
            => Parse(src.WithoutExtension.Name.Replace(Chars.Dot, UriDelimiters.PathSep));

        [MethodImpl(Inline)]
        public static ApiHostUri FromHost<H>()
            => FromHost(typeof(H));

        [MethodImpl(Inline)]
        public static ApiHostUri Define(PartId owner, string name)
            => new ApiHostUri(owner,name);
     
        [MethodImpl(Inline)]
        public static bool operator==(ApiHostUri a, ApiHostUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiHostUri a, ApiHostUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        internal ApiHostUri(PartId owner, string name)
        {
            Owner = owner;
            Name = name;
            UriText = owner != 0 ? $"{Owner.Format()}{UriDelimiters.PathSep}{Name}" : name;
        } 
        public string Format()
            => UriText;

        [MethodImpl(Inline)]
        public bool Equals(ApiHostUri src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiHostUri other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();

        public static ApiHostUri Empty 
            => new ApiHostUri(PartId.None, string.Empty);
    }
}