//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a stateless service
    /// </summary>
    public class FormatCodeAttribute : Attribute
    {
        public char Code {get;}

        public FormatCodeKind Kind {get;}

        public FormatCodeAttribute()
        {
            Code = ' ';
            Kind = FormatCodeKind.General;
        }

        public FormatCodeAttribute(FormatCodeKind kind, char code)
        {
            Code = code;
            Kind = kind;
        }

        public FormatCodeAttribute(FormatCodeKind kind, string code)
        {
            var s = (code  ?? " ");
            Code =  s.Length >= 1 ? s[0] : ' ';
            Kind = kind;
        }

        public FormatCodeAttribute(FormatCodeKind kind, object code)
        {
            var s = code?.ToString() ?? "";
            Code =  s.Length >= 1 ? s[0] : ' ';
            Kind = kind;
        }

        public FormatCodeAttribute(char code)
        {
            Code = code;
            Kind = FormatCodeKind.General;
        }

        public FormatCodeAttribute(string code)
        {
            var s = (code  ?? " ");
            Code =  s.Length >= 1 ? s[0] : ' ';
            Kind = FormatCodeKind.General;
        }

        public FormatCodeAttribute(object code)
        {
            var s = code?.ToString() ?? "";
            Code =  s.Length >= 1 ? s[0] : ' ';
            Kind = FormatCodeKind.General;
        }
    }
}