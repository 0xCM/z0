//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiPack : IApiPack
    {
        public FS.FolderPath Root {get;}

        readonly Env _Env;

        [MethodImpl(Inline)]
        public ApiPack(FS.FolderPath root)
        {
            Root = root;
            _Env = Env.load();
        }

        public Env Env
            => _Env;

        public Timestamp Timestamp
            => ParseTimestamp().Data;

        public Outcome<Timestamp> ParseTimestamp()
        {
            if(Root.IsEmpty)
                return default;

            var fmt = Root.Format(PathSeparator.FS);
            var idx = fmt.LastIndexOf(Chars.FSlash);
            if(idx == NotFound)
                return (false, "Path separator not found");

            var outcome = Time.parse(fmt.RightOfIndex(idx), out var ts);
            if(outcome)
                return ts;
            else
                return(false, outcome.Message);
        }

        public string Format()
            => string.Format("{0}: {1}", ParseTimestamp(), Root);

        public override string ToString()
            => Format();
    }
}