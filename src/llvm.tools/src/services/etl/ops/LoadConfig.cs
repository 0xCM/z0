//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    using K = llvm.LlvmConfigKind;

    partial class LlvmEtlServices
    {
        public LlvmConfig ComputeConfig()
        {
            const string Pattern = "llvm-config --{0}";
            var result = Outcome.Success;
            var options = Symbols.index<K>().View;
            var count = options.Length;
            var dst = new LlvmConfig();
            for(var i=0; i<count; i++)
            {
                ref readonly var option = ref skip(options,i);
                result = OmniScript.Run(string.Format(Pattern, option.Expr), out var response);
                if(result.Fail)
                {
                    Write(result.Message);
                }

                if(response.Length != 0)
                    StoreConfigValue(option, first(response), dst);
            }

            return dst;
        }

        void StoreConfigValue(Sym<LlvmConfigKind> sym, TextLine src, LlvmConfig dst)
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
                {
                    dst.Set(kind, content);
                    Write(content);
                }
                break;
                case K.IncludeDir:
                {
                    var data = FS.dir(content);
                    dst.Set(kind, data);
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
                    dst.Set(kind, data);
                    iter(data, c => Write(c));
                }
                break;
                case K.SrcRoot:
                {
                    var dir = FS.dir(content);
                    dst.Set(kind, dir);
                    Write(dir);
                }
                break;
                case K.ObjRoot:
                {
                    var data = FS.dir(content);
                    dst.Set(kind, data);
                    Write(data);
                }
                break;
                case K.BinDir:
                {
                    var data = FS.dir(content);
                    dst.Set(kind, data);
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
                    dst.Set(kind, data);
                    iter(data, c => Write(c));
                }
                break;
                case K.CxxFlags:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind, data);
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
                    dst.Set(kind, data);
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
                    dst.Set(kind, data);
                    iter(data, c => Write(c));
                }
                break;
                case K.LinkStatic:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty);
                    dst.Set(kind, data);
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
                    dst.Set(kind, data);
                    iter(data,p => Write(p.ToUri()));
                }
                break;
                case K.LibFiles:
                {
                    var data = content.Split(Chars.Space).Select(x => x.Trim()).Where(nonempty).Select(FS.path);
                    dst.Set(kind, data);
                    iter(data,p =>  Write(p.ToUri()));
                }
                break;
            }
        }
    }
}