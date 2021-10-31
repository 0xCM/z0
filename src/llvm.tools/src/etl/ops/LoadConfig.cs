//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    using K = llvm.LlvmConfigKind;

    partial class LlvmEtlServices
    {
        public LlvmConfig LoadConfig()
        {
            const string Pattern = "llvm-config --{0}";
            var result = Outcome.Success;
            var options = Symbols.index<K>().View;
            var count = options.Length;
            var config = new LlvmConfig();
            for(var i=0; i<count; i++)
            {
                ref readonly var option = ref skip(options,i);
                var script = string.Format(Pattern, option.Expr);
                result = OmniScript.Run(script, out var response);
                if(result.Fail)
                {
                    Write(result.Message);
                }

                if(response.Length != 0)
                    LoadConfig(option, first(response), config);
            }

            return config;
        }

        void LoadConfig(Sym<K> sym, TextLine src, LlvmConfig dst)
        {
            var content = text.trim(src.Content);
            if(empty(content))
                return;

            var kind = sym.Kind;
            Write(sym.Name, sym.Description, FlairKind.StatusData);
            Write(RP.PageBreak80, FlairKind.StatusData);
            switch(kind)
            {
                case K.Version:
                    Write(content);
                break;
                case K.IncludeDir:
                {
                    var data = FS.dir(content);
                    dst.Set(kind,data);
                    Write(data);
                }
                break;
                case K.LibDir:
                {
                    var data = FS.dir(content);
                    dst.Set(kind,data);
                    Write(data);
                }
                break;
                case K.TargetsBuilt:
                {
                    var data = content.Split(Chars.Space);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.SrcRoot:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.ObjRoot:
                {
                    var data = FS.dir(content);
                    dst.Set(kind,data);
                    Write(data);
                }
                break;
                case K.BinDir:
                {
                    var data = FS.dir(content);
                    dst.Set(kind,data);
                    Write(data);
                }
                break;
                case K.HostTarget:
                {
                    dst.Set(kind, content);
                    Write(content);
                }
                break;
                case K.CFlags:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.CxxFlags:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.SystemLibs:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty).Select(FS.file);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.LibNames:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty).Select(FS.file);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.CppFlags:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.LinkerFlags:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.LinkStatic:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.Components:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind,data);
                    iter(data, c => Write(c));
                }
                break;
                case K.Libs:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty).Select(FS.path);
                    dst.Set(kind,data);
                    iter(data,p =>  Write(p.ToUri()));
                }
                break;
                case K.LibFiles:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty).Select(FS.path);
                    dst.Set(kind,data);
                    iter(data,p =>  Write(p.ToUri()));
                }
                break;
            }
        }
    }
}