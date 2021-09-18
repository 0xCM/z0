//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public class RecordParser
    {
        public static RecordParser create(string match)
            => new RecordParser(match);

        List<RecordField> Fields;

        List<TextLine> Lines;

        string EnityName;

        string Match;

        RecordParser(string match)
        {
            Fields = new();
            Lines  = new();
            EnityName = EmptyString;
            Match = match;
        }

        const string FieldsMarker = "Fields:";

        public static bool fieldstart(string content)
            => text.contains(content, FieldsMarker);

        public static TextLine unpiped(in TextLine src)
        {
            var content = src.Content;
            if(!text.contains(content,CommonFields.AsmString))
            {
                var i = text.index(content,Chars.Pipe);
                if(i > 0)
                    return new TextLine(src.LineNumber, text.left(content,i).TrimEnd());

            }
            return src;
        }

        public static bool field(string content, out RecordField dst)
        {
            dst = RecordField.Empty;
            if(text.begins(content, RP.Spaced4))
            {
                var spec = text.slice(content,4);
                var i = text.index(spec, Chars.Space);
                if(i >=0)
                {
                    dst.Type = text.left(spec,i);
                    var nameval = text.right(spec,i);
                    i = text.index(nameval, Chars.Space);
                    if(i >=0)
                    {
                        dst.Name = text.left(nameval,i);
                        i = text.index(nameval,Chars.Eq);
                        if(i >=0)
                        {
                            var j = text.index(nameval, Chars.Pipe);
                            if(j >=0)
                            {
                                dst.Value = text.inside(nameval,i,j).Trim();
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}