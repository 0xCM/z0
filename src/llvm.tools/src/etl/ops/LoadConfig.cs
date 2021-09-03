//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using K = llvm.LlvmConfigKind;

    partial class EtlWorkflow
    {
        public Outcome LoadConfig()
        {
            const string Pattern = "llvm-config --{0}";
            var result = Outcome.Success;
            var options = Symbols.index<K>().View;
            var count = options.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var option = ref skip(options,i);
                var script = string.Format(Pattern, option.Expr);
                result = Wf.OmniScript().Run(script, out var response);
                if(result.Fail)
                    return result;

                if(response.Length != 0)
                    ProcessConfig(option, first(response));
            }

            return result;
        }

        void ProcessConfig(Sym<K> sym, TextLine src)
        {
            var content = src.Content;
            var kind = sym.Kind;
            Write(EmptyString);
            Write(sym.Name, sym.Description, FlairKind.StatusData);
            Write(RP.PageBreak40, FlairKind.StatusData);
            switch(kind)
            {
                case K.Version:
                    Write(content);
                break;
                case K.IncludeDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.LibDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.TargetsBuilt:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
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
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.BinDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.HostTarget:
                {
                    Write(content);
                }
                break;
                case K.CFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.CxxFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.SystemLibs:
                {
                    var items = content.Split(Chars.Space).Select(FS.file);
                    iter(items, c => Write(c));
                }
                break;
                case K.LibNames:
                {
                    var items = content.Split(Chars.Space).Select(FS.file);
                    iter(items, c => Write(c));
                }
                break;
                case K.CppFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.LinkerFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.LinkStatic:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.Components:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.Libs:
                {
                    var items = content.Split(Chars.Space).Select(FS.path);
                    iter(items,p =>  Write(p.ToUri()));
                }
                break;
                case K.LibFiles:
                {
                    var items = content.Split(Chars.Space).Select(FS.path);
                    iter(items,p =>  Write(p.ToUri()));
                }
                break;
            }
        }
    }
}