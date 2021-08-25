//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct ListItems
    {
        public static ListItem record<T>(ListItem<T> src, string type)
        {
            var dst = new ListItem();
            dst.Id = src.Index;
            dst.Type = type;
            dst.Value = src.Content?.ToString() ?? RP.Empty;
            return dst;
        }

        public static Outcome parse(string src, out ListItem dst)
        {
            dst = default;
            var parts = src.SplitClean(Chars.Pipe);
            if(parts.Length < 3)
                return (false, AppMsg.FieldCountMismatch.Format(3, parts.Length));

            Outcome result = true;

            result = uint.TryParse(skip(parts,0), out dst.Id);
            if(result.Fail)
                return (false, "Parsing item id failed");

            dst.Type = skip(parts,1);
            dst.Value = skip(parts,2);
            return result;
        }
    }
}